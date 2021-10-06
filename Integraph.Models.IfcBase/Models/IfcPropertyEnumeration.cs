using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertyenumeration.htm" />
	/// </summary>
	public class IfcPropertyEnumeration : IfcPropertyAbstraction
    {
	    /// <summary>
	    ///     Construct a IfcPropertyEnumeration with all required attributes.
	    /// </summary>
	    public IfcPropertyEnumeration(IfcLabel name, List<IfcValue> enumerationValues)
        {
            Name = name;
            EnumerationValues = enumerationValues;
        }

	    /// <summary>
	    ///     Construct a IfcPropertyEnumeration with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertyEnumeration(IfcLabel name, List<IfcValue> enumerationValues, IfcUnit unit)
        {
            Name = name;
            EnumerationValues = enumerationValues;
            Unit = unit;
        }

        public IfcLabel Name { get; set; }
        public List<IfcValue> EnumerationValues { get; set; }
        public IfcUnit Unit { get; set; } // optional

        public new static IfcPropertyEnumeration FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertyEnumeration>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            EnumerationValues != null ? EnumerationValues.ToStepValue() : "$",
	            Unit != null ? Unit.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}