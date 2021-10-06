using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertyboundedvalue.htm" />
	/// </summary>
	public class IfcPropertyBoundedValue : IfcSimpleProperty
    {
	    /// <summary>
	    ///     Construct a IfcPropertyBoundedValue with all required attributes.
	    /// </summary>
	    public IfcPropertyBoundedValue(IfcIdentifier name) : base(name)
        {
        }

	    /// <summary>
	    ///     Construct a IfcPropertyBoundedValue with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertyBoundedValue(IfcIdentifier name, IfcText description, IfcValue upperBoundValue,
            IfcValue lowerBoundValue, IfcUnit unit, IfcValue setPointValue) : base(name, description)
        {
            UpperBoundValue = upperBoundValue;
            LowerBoundValue = lowerBoundValue;
            Unit = unit;
            SetPointValue = setPointValue;
        }

        public IfcValue UpperBoundValue { get; set; } // optional
        public IfcValue LowerBoundValue { get; set; } // optional
        public IfcUnit Unit { get; set; } // optional
        public IfcValue SetPointValue { get; set; } // optional

        public new static IfcPropertyBoundedValue FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertyBoundedValue>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            UpperBoundValue != null ? UpperBoundValue.ToStepValue() : "$",
	            LowerBoundValue != null ? LowerBoundValue.ToStepValue() : "$",
	            Unit != null ? Unit.ToStepValue() : "$",
	            SetPointValue != null ? SetPointValue.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}