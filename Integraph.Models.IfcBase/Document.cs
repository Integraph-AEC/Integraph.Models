using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Integraph.Models.IfcBase.Models;
using Integraph.Models.IfcBase.Step;
using Integraph.Models.IfcBase.STEP;

namespace Integraph.Models.IfcBase
{
    /// <summary>
    ///     A Document contains a collection of entities.
    /// </summary>
    public class Document
    {
        private const string AppName = "IFC-dotnet";
        private readonly IDictionary<Guid, BaseIfc> _storage = new Dictionary<Guid, BaseIfc>();

        /// <summary>
        ///     Construct a document.
        ///     The document will have all unit types set to SI units.
        /// </summary>
        /// <param name="projectName">The name of the project.</param>
        /// <param name="projectDescription">The description of the project.</param>
        /// <param name="userId">The id of the user.</param>
        /// <param name="userLastName">The last name of the user.</param>
        /// <param name="userFirstName">The first name of the user.</param>
        /// <param name="userEmailAddress">The email address of the user.</param>
        /// <param name="orgName">The user's organization.</param>
        /// <param name="orgDescription">A description of the user's organization.</param>
        /// <param name="addressDescription">A description of the address.</param>
        /// <param name="street">The street.</param>
        /// <param name="city">The city.</param>
        /// <param name="poBox">The PO box.</param>
        /// <param name="state">The state.</param>
        /// <param name="postalCode">The postal code.</param>
        /// <param name="country">The country.</param>
        public Document(string projectName,
            string projectDescription = null,
            string userId = null,
            string userLastName = null,
            string userFirstName = null,
            string userEmailAddress = null,
            string orgName = null,
            string orgDescription = null,
            string addressDescription = null,
            string street = null,
            string city = null,
            string poBox = null,
            string state = null,
            string postalCode = null,
            string country = null)
        {
            // Create an organization for app creation.
            var appOrg = new IfcOrganization(AppName);
            AddEntity(appOrg);

            // Create an authoring application.
            var v = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            var app = new IfcApplication(appOrg, v, AppName, AppName);
            AddEntity(app);

            var orgAddress = AddAddress(addressDescription, street, city, poBox, state, postalCode, country);
            var person = AddPerson(userId, userLastName, userFirstName, userEmailAddress, IfcRoleEnum.Architect);
            var org = AddOrganization(orgName, orgDescription, orgAddress);

            // Create an person and history for the owner history.
            var personAndOrg = new IfcPersonAndOrganization(person, org);
            AddEntity(personAndOrg);

            // Create an owner history for the project.
            var history = new IfcOwnerHistory(personAndOrg, app, UnixNow());
            AddEntity(history);

            var unitAss = AddUnitAssignment();

            var geo = AddGeometricContext();

            // Create the project.
            var proj = new IfcProject(IfcGuid.ToIfcGuid(Guid.NewGuid()), history, projectName, projectDescription, null,
                null, null, new List<IfcRepresentationContext> {geo}, unitAss);
            AddEntity(proj);
        }

        /// <summary>
        ///     Create a document given a STEP file.
        /// </summary>
        /// <param name="stepFilePath">The path to the STEP file.</param>
        /// <param name="errors">A list of errors generated during creation of the Document.</param>
        /// <returns>A Model.</returns>
        /// <exception cref="FileNotFoundException">The specified file path does not exist.</exception>
        public Document(string stepFilePath, out List<StepError> errors)
        {
            if (!File.Exists(stepFilePath))
                throw new FileNotFoundException($"The specified IFC STEP file does not exist: {stepFilePath}.");

            errors = new List<StepError>();

            using var fs = new FileStream(stepFilePath, FileMode.Open);
            var sw = new Stopwatch();
            sw.Start();

            var input = new AntlrInputStream(fs);
            var lexer = new STEPLexer(input);
            var tokens = new CommonTokenStream(lexer);

            var parser = new STEPParser(tokens)
            {
                BuildParseTree = true
            };

            var tree = parser.file();
            var walker = new ParseTreeWalker();

            var listener = new StepListener();
            walker.Walk(listener, tree);

            sw.Stop();
            Console.WriteLine($"{sw.Elapsed} for parsing STEP file {stepFilePath}.");
            sw.Reset();

            sw.Start();
            var err = new List<StepError>();
            foreach (var data in listener.InstanceData.Where(data => listener.InstanceData[data.Key].ConstructedInstance == null))
            {
                ConstructAndStoreInstance(data.Value, listener.InstanceData, data.Key, err, 0);
            }

            // Transfer the constructed instances to storage.
            foreach (var inst in listener.InstanceData.Select(data => data.Value.ConstructedInstance))
            {
                AddEntity(inst);
            }

            sw.Stop();
            Console.WriteLine($"{sw.Elapsed} for creating instances.");

            errors = err;
        }

        /// <summary>
        ///     Get all entities in the document.
        /// </summary>
        public IEnumerable<BaseIfc> AllEntities => _storage.Values;

        private IfcGeometricRepresentationContext AddGeometricContext()
        {
            //Ex: #38= IFCGEOMETRICREPRESENTATIONCONTEXT($,'Model',3,0.000010,#36,#37);
            var coordinateSpaceDimension = new IfcDimensionCount(3);
            var location = new IfcCartesianPoint(new List<IfcLengthMeasure> {0, 0, 0});
            var up = new IfcDirection(new List<IfcReal> {0, 0, 1});
            var x = new IfcDirection(new List<IfcReal> {1, 0, 0});
            AddEntity(location);
            AddEntity(up);
            AddEntity(x);
            var place3d = new IfcAxis2Placement3D(location, up, x);
            var worldCs = new IfcAxis2Placement(place3d);
            var north = new IfcDirection(new List<IfcReal> {0, 1, 0});
            // this.AddEntity(worldCs);
            AddEntity(place3d);
            AddEntity(north);
            var geo = new IfcGeometricRepresentationContext(null, new IfcLabel("Model"), coordinateSpaceDimension,
                0.000010, worldCs, north);
            AddEntity(geo);
            return geo;
        }

        /// <summary>
        ///     Add an entity to the document.
        /// </summary>
        /// <param name="entity">The entity to add to the document.</param>
        private void AddEntity(BaseIfc entity)
        {
            // Add the entity and recursively add all sub entities.
            if (_storage.ContainsKey(entity.Id)) return;

            _storage.Add(entity.Id, entity);
        }

        /// <summary>
        ///     Write the document to STEP.
        /// </summary>
        /// <returns>A string representing the model serialized to STEP.</returns>
        public string ToStep(string filePath)
        {
            var sw = new Stopwatch();
            sw.Start();

            var builder = new StringBuilder();
            builder.AppendLine(Begin(filePath));

            var index = 1;
            foreach (var element in _storage.Values)
            {
                element.StepId = index;
                index++;
            }

            foreach (var element in _storage.Values)
            {
                var instanceValue = element.ToStep();
                builder.AppendLine(instanceValue);
            }

            builder.Append(End());

            sw.Stop();
            Console.WriteLine($"{sw.Elapsed} for serializing Document to STEP.");

            return builder.ToString();
        }

        /// <summary>
        ///     Get all instances whose type derives from Tifc.
        /// </summary>
        /// <typeparam name="TIfc">A base type of the instances.</typeparam>
        /// <returns>A collection of BaseIfc.</returns>
        public IEnumerable<TIfc> AllInstancesDerivedFromType<TIfc>()
        {
            return _storage.Values.Where(e => e is TIfc).Cast<TIfc>();
        }

        /// <summary>
        ///     Get all instances of type Tifc.
        /// </summary>
        /// <typeparam name="TIfc">The type of the instances.</typeparam>
        /// <returns>A collection of BaseIfc.</returns>
        private IEnumerable<TIfc> AllInstancesOfType<TIfc>()
        {
            return _storage.Values.Where(e => e.GetType() == typeof(TIfc)).Cast<TIfc>();
        }

        /// <summary>
        ///     Create an IfcUnitAssignment.
        /// </summary>
        /// <returns></returns>
        private IfcUnitAssignment AddUnitAssignment()
        {
            var lu = new IfcSiUnit(null, IfcUnitEnum.LengthUnit, IfcSiUnitName.Metre);
            AddEntity(lu);
            var lengthUnit = new IfcUnit(lu);

            var au = new IfcSiUnit(null, IfcUnitEnum.AreaUnit, IfcSiUnitName.SquareMetre);
            AddEntity(au);
            var areaUnit = new IfcUnit(au);

            var vu = new IfcSiUnit(null, IfcUnitEnum.VolumeUnit, IfcSiUnitName.CubicMetre);
            AddEntity(vu);
            var volumeUnit = new IfcUnit(vu);

            var sau = new IfcSiUnit(null, IfcUnitEnum.SolidAngleUnit, IfcSiUnitName.Steradian);
            AddEntity(sau);
            var solidAngleUnit = new IfcUnit(sau);

            var mu = new IfcSiUnit(null, IfcUnitEnum.MassUnit, IfcSiUnitName.Gram);
            AddEntity(mu);
            var massUnit = new IfcUnit(mu);

            var tu = new IfcSiUnit(null, IfcUnitEnum.Timeunit, IfcSiUnitName.Second);
            AddEntity(tu);
            var timeUnit = new IfcUnit(tu);

            var thu = new IfcSiUnit(null, IfcUnitEnum.ThermodynamicTemperatureUnit, IfcSiUnitName.DegreeCelsius);
            AddEntity(thu);
            var thermUnit = new IfcUnit(thu);

            var lmu = new IfcSiUnit(null, IfcUnitEnum.LuminousIntensityUnit, IfcSiUnitName.Lumen);
            AddEntity(lmu);
            var lumUnit = new IfcUnit(lmu);

            var pau = new IfcSiUnit(null, IfcUnitEnum.PlaneAngleUnit, IfcSiUnitName.Radian);
            AddEntity(pau);
            var planeAngleUnit = new IfcUnit(pau);

            var measure = new IfcMeasureWithUnit(new IfcValue(new IfcMeasureValue(new IfcPlaneAngleMeasure(1.745e-2))),
                planeAngleUnit);
            AddEntity(measure);

            var dimExp = new IfcDimensionalExponents(0, 0, 0, 0, 0, 0, 0);
            AddEntity(dimExp);

            var du = new IfcConversionBasedUnit(dimExp, IfcUnitEnum.PlaneAngleUnit, "DEGREE", measure);
            AddEntity(du);
            var degree = new IfcUnit(du);

            var units = new List<IfcUnit>
            {
                lengthUnit, areaUnit, volumeUnit, solidAngleUnit, massUnit, timeUnit, thermUnit, lumUnit,
                planeAngleUnit, degree
            };
            var unitAss = new IfcUnitAssignment(units);
            AddEntity(unitAss);

            return unitAss;
        }

        /// <summary>
        ///     Create an IfcAddress.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="poBox"></param>
        /// <param name="state"></param>
        /// <param name="postalCode"></param>
        /// <param name="country"></param>
        /// <returns></returns>
        private IfcPostalAddress AddAddress(string description, string street, string city, string poBox, string state,
            string postalCode, string country)
        {
            var lines = street != null ? new List<IfcLabel> {street} : null;
            var address = new IfcPostalAddress(IfcAddressTypeEnum.Office, description, null, null, lines, poBox, city,
                state, postalCode, country);
            AddEntity(address);
            return address;
        }

        /// <summary>
        ///     Create an IfcPerson.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        private IfcPerson AddPerson(string userId, string lastName, string firstName, string emailAddress,
            IfcRoleEnum role)
        {
            var r = new IfcActorRole(role);
            AddEntity(r);
            var person = new IfcPerson(userId, lastName, firstName, null, null, null, new List<IfcActorRole> {r}, null);
            AddEntity(person);
            return person;
        }

        /// <summary>
        ///     Create an IfcOrganization.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        private IfcOrganization AddOrganization(string name, string description, IfcAddress address)
        {
            // Create an organization to own the Project
            var org = new IfcOrganization(name, name, description,
                new List<IfcActorRole>(), new List<IfcAddress> {address});
            AddEntity(org);
            return org;
        }

        private string Begin(string filePath)
        {
            var project = AllInstancesOfType<IfcProject>().FirstOrDefault();
            var org = project != null ? project.OwnerHistory.OwningUser.TheOrganization.Name : new IfcLabel("Integraph");
            return $@"
ISO-10303-21;
HEADER;
FILE_DESCRIPTION(
	('ViewDefinition [DesignTransferView_V1.0]'),
	'2;1');
FILE_NAME(
    '{filePath}',
    '{DateTime.Now:yyyy-MM-ddTHH:MM:ss}',
    ('{Environment.UserName}'),
    ('{org}'),
    'IFC-dotnet',
    '{typeof(Document).Assembly.GetName().Version}',
	'None');
FILE_SCHEMA (('IFC4'));
ENDSEC;
DATA;";
        }

        private static string End()
        {
            return @"ENDSEC;
END-ISO-10303-21;";
        }

        /// <summary>
        ///     Recursively construct instances provided instance data.
        ///     Construction is recursive because the instance data might include other
        ///     instance data or id references to instances which have not yet been
        ///     constructed.
        /// </summary>
        /// <param name="data">The instance data from which to construct the instance.</param>
        /// <param name="instances">The dictionary containing instance data gathered from the parser.</param>
        /// <param name="currLine">The number of the current line</param>
        /// <param name="errors"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        private static object ConstructAndStoreInstance(InstanceData data, IReadOnlyDictionary<int, InstanceData> instances,
            int currLine, ICollection<StepError> errors, int level)
        {
            string.Join("", Enumerable.Repeat("\t", level));

            //     Console.WriteLine($"{indent}{currLine},{data.Id} : Constructing type {data.Type.Name} with parameters [{string.Join(",",data.Parameters)}]");

            for (var i = 0; i < data.Parameters.Count; i++)
                switch (data.Parameters[i])
                {
                    case InstanceData:
                        data.Parameters[i] = ConstructAndStoreInstance((InstanceData) data.Parameters[i], instances,
                            currLine, errors, level);
                        break;
                    case StepId:
                    {
                        var stepId = data.Parameters[i] as StepId;

                        // The instance has already been constructed.
                        // Use the id to look it up.
                        if (instances.ContainsKey(stepId.Value))
                        {
                            if (instances[stepId.Value].ConstructedInstance != null)
                            {
                                //Console.WriteLine($"{indent}Using pre-created instance {stepId.Value}");
                                data.Parameters[i] = instances[stepId.Value].ConstructedInstance;
                                continue;
                            }
                        }
                        // The instance's id cannot be found in the map.
                        // Log an error and set the parameter value to null.
                        else
                        {
                            errors.Add(new MissingIdError(currLine, stepId.Value));
                            data.Parameters[i] = null;
                            continue;
                        }

                        data.Parameters[i] =
                            ConstructAndStoreInstance(instances[stepId.Value], instances, currLine, errors, level);
                        break;
                    }
                    case List<object>:
                    {
                        var list = data.Parameters[i] as List<object>;

                        // The parameters will have been stored in a List<object> during parsing.
                        // We need to create a List<T> where T is the type expected by the constructor
                        // in the STEP file.
                        var listType = typeof(List<>);
                        var instanceType = data.Constructor.GetParameters()[i].ParameterType.GetGenericArguments()[0];
                        var constructedListType = listType.MakeGenericType(instanceType);
                        var subInstances = (IList) Activator.CreateInstance(constructedListType);

                        if (!list.Any())
                        {
                            // Return our newly type empty list.
                            data.Parameters[i] = subInstances;
                            continue;
                        }

                        foreach (var item in list)
                            switch (item)
                            {
                                case StepId stepId:
                                {
                                    // Do a check for an existing instance with this id.
                                    if (instances.ContainsKey(stepId.Value))
                                        if (instances[stepId.Value].ConstructedInstance != null)
                                        {
                                            var existing = CoerceObject(instances[stepId.Value].ConstructedInstance, instanceType);
                                            subInstances.Add(existing);
                                            continue;
                                        }

                                    var subInstance = ConstructAndStoreInstance(instances[stepId.Value], instances, currLine,
                                        errors, level);
                                    var coerce = CoerceObject(subInstance, instanceType);
                                    subInstances.Add(coerce);
                                    break;
                                }
                                case InstanceData instanceData:
                                {
                                    var subInstance = ConstructAndStoreInstance(instanceData, instances, currLine,
                                        errors, level);
                                    var coerce = CoerceObject(subInstance, instanceType);
                                    subInstances.Add(coerce);
                                    break;
                                }
                                default:
                                {
                                    var coerce = CoerceObject(item, instanceType);
                                    subInstances.Add(coerce);
                                    break;
                                }
                            }

                        // Replace the list of STEPId with a list of instance references.
                        data.Parameters[i] = subInstances;
                        break;
                    }
                }

            for (var i = 0; i < data.Parameters.Count; i++)
                data.Parameters[i] =
                    CoerceObject(data.Parameters[i], data.Constructor.GetParameters()[i].ParameterType);

            // Construct the instance, assuming that all required sub-instances
            // have already been constructed.
            var instance = data.Constructor.Invoke(data.Parameters.ToArray());

            if (instance == null)
                throw new Exception(
                    $"Could not construct an instance of {data.Constructor.DeclaringType} with parameters {data.Parameters}.");

            // Inline instances will have an id of -1. Don't store these.
            // But DO return them to be used as constructor parameters.
            if (data.Id != -1) instances[data.Id].ConstructedInstance = (BaseIfc) instance;

            //Console.WriteLine($"Setting instanceDataMap[{data.Id}] constructed instance as {instance.Id} for type {instance.GetType().Name}.");
            return instance;
        }

        private static object CoerceObject(object value, Type to)
        {
            if (value == null) return null;

            var result = value;
            if (!typeof(Select).IsAssignableFrom(to)) return result;
            var ctorChain = new List<ConstructorInfo>();
            if (!StepListener.TypeHasConstructorForSelectChoice(to, value.GetType(), out var ctor, ref ctorChain))
                return result;
            result = ctor.Invoke(new[] {value});
            if (!ctorChain.Any()) return result;
            for (var y = ctorChain.Count - 1; y >= 0; y--)
                result = ctorChain[y].Invoke(new[] {result});

            return result;
        }

        private static int UnixNow()
        {
            return (int) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }
    }
}