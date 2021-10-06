using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Integraph.Models.IfcBase.Models;
using Integraph.Models.IfcBase.Step;

namespace Integraph.Models.IfcBase.STEP
{
    public class StepId
    {
        public StepId(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }

    public class InstanceData
    {
        public InstanceData(int id, Type type, List<object> parameters, ConstructorInfo ctor,
            List<ConstructorInfo> ctorChain = null)
        {
            Id = id;
            Type = type;
            Parameters = parameters;
            Constructor = ctor;
            ConstructorChain = ctorChain;
        }

        public int Id { get; set; }
        public Type Type { get; set; }
        public List<object> Parameters { get; set; }

        public List<ConstructorInfo> ConstructorChain { get; set; }
        public ConstructorInfo Constructor { get; set; }

        /// <summary>
        ///     The BaseIfc instance constructed using this data.
        /// </summary>
        /// <returns></returns>
        public BaseIfc ConstructedInstance { get; set; }

        public bool HasDependencies
        {
            get { return Parameters.Any(p => p is StepId); }
        }
    }

    public class StepListener : STEPBaseListener
    {
        private int _currId;
        private IEnumerable<Type> _enums;

        private readonly Dictionary<string, Type> _types;

        public StepListener()
        {
            InstanceData = new Dictionary<int, InstanceData>();

            // Parsing will involve finding many enum values
            // Cache the enum types for lookup during parsing. 
            _enums = typeof(Document).Assembly.GetTypes().Where(t => t.IsEnum).ToList();
            _types = new Dictionary<string, Type>();
            foreach (var item in typeof(Document).Assembly.GetTypes().Where(t => !t.IsEnum))
            {
                var key = item.Name.ToUpper();
                if (!_types.ContainsKey(key)) _types[key] = item;
            }
        }

        public Dictionary<int, InstanceData> InstanceData { get; }

        public override void EnterInstance(STEPParser.InstanceContext context)
        {
            _currId = int.Parse(context.Id().GetText().TrimStart('#'));
        }

        public override void EnterConstructor(STEPParser.ConstructorContext context)
        {
            // Only cache an instance if it's an outer instance.
            if (context.Parent is STEPParser.InstanceContext)
                InstanceData.Add(_currId, ParseConstructor(_currId, context));
        }

        private static ConstructorInfo GetConstructorForType(Type required, ref List<ConstructorInfo> ctorChain,
            Type fromStep = null)
        {
            var constructors = required.GetConstructors();

            if (fromStep == null || required.IsAssignableFrom(fromStep))
                return constructors.OrderBy(c => c.GetParameters().Length).Last();

            ConstructorInfo ctor;

            if (typeof(Select).IsAssignableFrom(required))
                if (TypeHasConstructorForSelectChoice(required, fromStep, out ctor, ref ctorChain))
                    return ctor;

            // See if there is a constructor with the fromSTEP as its
            // only parameter.
            // Ex: IfcNormalisedRatioMeasure(IfcRatioMeasure value)
            ctor = constructors.FirstOrDefault(c => c.GetParameters().First().ParameterType == fromStep);
            if (ctor != null) return ctor;

            throw new Exception($"I could not find a constructor which would create a {required} from a {fromStep}.");
        }

        internal static bool TypeHasConstructorForSelectChoice(Type t, Type choice, out ConstructorInfo ctor,
            ref List<ConstructorInfo> cTorChain)
        {
            var constructorInfo = t.GetConstructors().ToArray();
            ctor = constructorInfo.FirstOrDefault(c => c.GetParameters()[0].ParameterType.IsAssignableFrom(choice));
            if (ctor != null)
                // You've found a constructor that takes the choice type.
                return true;

            // No select constructor could be found that could construct the type directly.
            // See if any of the params are selects and test those selects' constructors for a parameter
            // of foundType.
            foreach (var c in constructorInfo.Where(c =>
                c.GetParameters().Any(p => typeof(Select).IsAssignableFrom(p.ParameterType))))
            foreach (var p in c.GetParameters())
                if (TypeHasConstructorForSelectChoice(p.ParameterType, choice, out ctor, ref cTorChain))
                {
                    cTorChain.Add(c);
                    return true;
                }

            return false;
        }

        private InstanceData ParseConstructor(int id, STEPParser.ConstructorContext context, Type ifcType = null)
        {
            //Console.WriteLine($"Parsing constructor {id}.");

            var typeName = context.TypeRef().GetText();

            // If a type has been passed in, we're parsing a constructor
            // as a parameter of a constructor.
            if (ifcType == null)
            {
                if (!_types.ContainsKey(typeName)) throw new StepUnknownTypeException(typeName);
                ifcType = _types[typeName];
            }

            Type fromStep = null;
            if (_types.ContainsKey(typeName)) fromStep = _types[typeName];


            // Use the constructor which includes all non-optional parameters.
            var ctorChain = new List<ConstructorInfo>();
            var ctor = GetConstructorForType(ifcType, ref ctorChain, fromStep);

            if (ctorChain.Any())
            {
                string.Join("=>", ctorChain.Select(c => c.DeclaringType.Name));
            }

            var ctorParams = ctor.GetParameters();

            var constructorParams = new List<object>();

            var cParams = context.parameter();

            for (var i = 0; i < cParams.Length; i++)
            {
                var p = cParams[i];
                var pType = ctorParams[i].ParameterType;

                if (p.constructor() != null)
                    // If the parameter is a constructor, it may be a constructor
                    // for a type that is used as a select. 
                    // In this case, we will need to find the select
                    // for which the type is a parameter, and construct an instance
                    // of the select instead.
                    constructorParams.Add(ParseConstructor(-1, p.constructor(), pType));
                else if (p.collection() != null)
                    constructorParams.Add(ParseCollection(pType, p.collection()));
                else if (p.Undefined() != null)
                    constructorParams.Add(null);
                else if (p.StringLiteral() != null)
                    constructorParams.Add(ParseString(pType, p.StringLiteral().GetText()));
                else if (p.Derived() != null)
                    constructorParams.Add(null);
                else if (p.Enum() != null)
                    constructorParams.Add(ParseEnum(pType, p.Enum().GetText()));
                else if (p.BoolLogical() != null)
                    constructorParams.Add(ParseBoolLogical(pType, p.BoolLogical().GetText()));
                else if (p.RealLiteral() != null)
                    constructorParams.Add(ParseReal(pType, p.RealLiteral().GetText()));
                else if (p.AnyString() != null)
                    constructorParams.Add(ParseString(pType, p.AnyString().GetText()));
                else if (p.Id() != null)
                    constructorParams.Add(ParseId(p.Id().GetText()));
                else if (p.IntegerLiteral() != null)
                    constructorParams.Add(ParseInt(pType, p.IntegerLiteral().GetText()));
            }

            if (ctorParams.Length != constructorParams.Count)
                throw new StepParameterMismatchException(ifcType, ctorParams.Length, constructorParams.Count);

            return new InstanceData(id, ifcType, constructorParams, ctor, ctorChain);
        }

        private static dynamic ParseBoolLogical(Type t, string value)
        {
            var v = TrimDots(value);
            bool? result = v switch
            {
                "T" => true,
                "F" => false,
                "U" => null,
                _ => null
            };

            if (t == typeof(bool))
            {
                return result != null && (bool) result;
            }
            else if (t == typeof(bool?))
            {
                return result;
            }
            else
            {
                return CreateIfcTypeOrUseConstructorParameterTypeToConstruct(t, result);    
            }
            

            throw new StepParserException(typeof(bool?), value);
        }

        private static dynamic ParseId(string value)
        {
            if (!int.TryParse(value.TrimStart('#'), out var result)) throw new StepParserException(typeof(StepId), value);
            return new StepId(result);
        }

        private static dynamic ParseInt(Type t, string value)
        {
            if (!int.TryParse(value, out var result)) throw new StepParserException(typeof(int), value);

            return t == typeof(int) ? result : CreateIfcTypeOrUseConstructorParameterTypeToConstruct(t, result);
        }

        private static dynamic ParseReal(Type t, string value)
        {
            if (!double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
                throw new StepParserException(typeof(double), value);

            return t == typeof(double) ? result : CreateIfcTypeOrUseConstructorParameterTypeToConstruct(t, result);
        }

        private static object CreateIfcTypeOrUseConstructorParameterTypeToConstruct<TValue>(Type typeToConstruct, TValue value)
        {
            var ctorChain = new List<ConstructorInfo>();
            var ctor = GetConstructorForType(typeToConstruct, ref ctorChain);
            var cTorParam = ctor.GetParameters()[0];

            //Console.WriteLine($"TValue:{typeof(TValue).Name}, ParameterType:{cTorParam.ParameterType.Name}");
            if (typeof(TValue).IsAssignableFrom(cTorParam.ParameterType))
                return Activator.CreateInstance(typeToConstruct, value);

            var p = Activator.CreateInstance(cTorParam.ParameterType, value);
            return Activator.CreateInstance(typeToConstruct, p);
        }

        private static dynamic ParseString(Type t, string value)
        {
            try
            {
                var result = TrimQuotes(value);
                return t == typeof(string) ? result : CreateIfcTypeOrUseConstructorParameterTypeToConstruct(t, result);
            }
            catch (Exception)
            {
                throw new StepParserException(typeof(string), value);
            }
        }

        private static string TrimQuotes(string value)
        {
            return value.TrimStart('\'').TrimEnd('\'');
        }

        private static string TrimDots(string value)
        {
            return value.TrimStart('.').TrimEnd('.');
        }

        private static dynamic ParseEnum(Type t, string value)
        {
            var trimmedValue = TrimDots(value);
            if (!t.IsEnum) throw new StepParserException(t, value);

            try
            {
                return Enum.Parse(t, trimmedValue);
            }
            catch
            {
                throw new StepParserException(typeof(Enum), trimmedValue);
            }
        }

        private dynamic ParseCollection(Type t, STEPParser.CollectionContext value)
        {
            // Ex: #25 = IFCDIRECTION((1., 0., 0.));
            // IfcDirection takes a List<double> as its input parameters, so we get the type argument - double - and
            // do the coercion for all the items.

            // Ex: #31 = IFCSITE('3BoQ8L5UXBEOT1kW0PLzej', #2, 'Default Site', 'Description of Default Site', $, #32, $, $, .ELEMENT., (24, 28, 0), (54, 25, 0), 10., $, $);
            // IfcSite takes two IfcCompoundPlaneMeasure objects. It seems that some IFC exporters will not specify a type's constructor, they'll just
            // specify the arguments as a collection. 

            Type collectionType;
            ConstructorInfo ctor = null;
            var ctorChain = new List<ConstructorInfo>();

            if (t.IsGenericType)
            {
                collectionType = t.GetGenericArguments()[0];
            }
            else
            {
                ctor = GetConstructorForType(t, ref ctorChain);
                collectionType = ctor.GetParameters()[0].ParameterType.GetGenericArguments()[0];
            }

            var result = new List<object>();

            foreach (var cv in value.collectionValue())
                if (cv.Id() != null)
                    result.Add(ParseId(cv.Id().GetText()));
                else if (cv.AnyString() != null)
                    result.Add(ParseString(collectionType, cv.AnyString().GetText()));
                else if (cv.StringLiteral() != null)
                    result.Add(ParseString(collectionType, cv.StringLiteral().GetText()));
                else if (cv.IntegerLiteral() != null)
                    result.Add(ParseInt(collectionType, cv.IntegerLiteral().GetText()));
                else if (cv.RealLiteral() != null)
                    result.Add(ParseReal(collectionType, cv.RealLiteral().GetText()));
                else if (cv.constructor() != null) result.Add(ParseConstructor(_currId, cv.constructor()));

            if (ctor != null) return new InstanceData(-1, t, new List<object> {result}, ctor, ctorChain);

            return result;
        }
    }
}