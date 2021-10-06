using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcquantitycount.htm" />
	/// </summary>
	public class IfcQuantityCount : IfcPhysicalSimpleQuantity
    {
	    /// <summary>
	    ///     Construct a IfcQuantityCount with all required attributes.
	    /// </summary>
	    public IfcQuantityCount(IfcLabel name, IfcCountMeasure countValue) : base(name)
        {
            CountValue = countValue;
        }

	    /// <summary>
	    ///     Construct a IfcQuantityCount with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcQuantityCount(IfcLabel name, IfcText description, IfcNamedUnit unit, IfcCountMeasure countValue,
            IfcLabel formula) : base(name, description, unit)
        {
            CountValue = countValue;
            Formula = formula;
        }

        public IfcCountMeasure CountValue { get; set; }
        public IfcLabel Formula { get; set; } // optional

        public new static IfcQuantityCount FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcQuantityCount>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Unit != null ? Unit.ToStepValue() : "$",
	            CountValue != null ? CountValue.ToStepValue() : "$",
	            Formula != null ? Formula.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}