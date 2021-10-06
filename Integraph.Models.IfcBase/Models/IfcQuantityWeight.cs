using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcquantityweight.htm" />
	/// </summary>
	public class IfcQuantityWeight : IfcPhysicalSimpleQuantity
    {
	    /// <summary>
	    ///     Construct a IfcQuantityWeight with all required attributes.
	    /// </summary>
	    public IfcQuantityWeight(IfcLabel name, IfcMassMeasure weightValue) : base(name)
        {
            WeightValue = weightValue;
        }

	    /// <summary>
	    ///     Construct a IfcQuantityWeight with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcQuantityWeight(IfcLabel name, IfcText description, IfcNamedUnit unit, IfcMassMeasure weightValue,
            IfcLabel formula) : base(name, description, unit)
        {
            WeightValue = weightValue;
            Formula = formula;
        }

        public IfcMassMeasure WeightValue { get; set; }
        public IfcLabel Formula { get; set; } // optional

        public new static IfcQuantityWeight FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcQuantityWeight>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Unit != null ? Unit.ToStepValue() : "$",
	            WeightValue != null ? WeightValue.ToStepValue() : "$",
	            Formula != null ? Formula.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}