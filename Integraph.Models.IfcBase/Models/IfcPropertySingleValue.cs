using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertysinglevalue.htm" />
	/// </summary>
	public class IfcPropertySingleValue : IfcSimpleProperty
    {
	    /// <summary>
	    ///     Construct a IfcPropertySingleValue with all required attributes.
	    /// </summary>
	    public IfcPropertySingleValue(IfcIdentifier name) : base(name)
        {
        }

	    /// <summary>
	    ///     Construct a IfcPropertySingleValue with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertySingleValue(IfcIdentifier name, IfcText description, IfcValue nominalValue, IfcUnit unit) :
            base(name, description)
        {
            NominalValue = nominalValue;
            Unit = unit;
        }

        public IfcValue NominalValue { get; set; } // optional
        public IfcUnit Unit { get; set; } // optional

        public new static IfcPropertySingleValue FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertySingleValue>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            NominalValue != null ? NominalValue.ToStepValue() : "$",
	            Unit != null ? Unit.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}