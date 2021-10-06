using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertytablevalue.htm" />
	/// </summary>
	public class IfcPropertyTableValue : IfcSimpleProperty
    {
	    /// <summary>
	    ///     Construct a IfcPropertyTableValue with all required attributes.
	    /// </summary>
	    public IfcPropertyTableValue(IfcIdentifier name) : base(name)
        {
            DefiningValues = new List<IfcValue>();
            DefinedValues = new List<IfcValue>();
        }

	    /// <summary>
	    ///     Construct a IfcPropertyTableValue with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertyTableValue(IfcIdentifier name, IfcText description, List<IfcValue> definingValues,
            List<IfcValue> definedValues, IfcText expression, IfcUnit definingUnit, IfcUnit definedUnit,
            IfcCurveInterpolationEnum curveInterpolation) : base(name, description)
        {
            DefiningValues = definingValues;
            DefinedValues = definedValues;
            Expression = expression;
            DefiningUnit = definingUnit;
            DefinedUnit = definedUnit;
            CurveInterpolation = curveInterpolation;
        }

        public List<IfcValue> DefiningValues { get; set; } // optional
        public List<IfcValue> DefinedValues { get; set; } // optional
        public IfcText Expression { get; set; } // optional
        public IfcUnit DefiningUnit { get; set; } // optional
        public IfcUnit DefinedUnit { get; set; } // optional
        public IfcCurveInterpolationEnum? CurveInterpolation { get; set; } // optional

        public new static IfcPropertyTableValue FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertyTableValue>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            DefiningValues != null ? DefiningValues.ToStepValue() : "$",
	            DefinedValues != null ? DefinedValues.ToStepValue() : "$",
	            Expression != null ? Expression.ToStepValue() : "$",
	            DefiningUnit != null ? DefiningUnit.ToStepValue() : "$",
	            DefinedUnit != null ? DefinedUnit.ToStepValue() : "$",
	            CurveInterpolation.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}