using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertylistvalue.htm" />
	/// </summary>
	public class IfcPropertyListValue : IfcSimpleProperty
    {
	    /// <summary>
	    ///     Construct a IfcPropertyListValue with all required attributes.
	    /// </summary>
	    public IfcPropertyListValue(IfcIdentifier name) : base(name)
        {
            ListValues = new List<IfcValue>();
        }

	    /// <summary>
	    ///     Construct a IfcPropertyListValue with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertyListValue(IfcIdentifier name, IfcText description, List<IfcValue> listValues, IfcUnit unit) :
            base(name, description)
        {
            ListValues = listValues;
            Unit = unit;
        }

        public List<IfcValue> ListValues { get; set; } // optional
        public IfcUnit Unit { get; set; } // optional

        public new static IfcPropertyListValue FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertyListValue>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ListValues != null ? ListValues.ToStepValue() : "$",
	            Unit != null ? Unit.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}