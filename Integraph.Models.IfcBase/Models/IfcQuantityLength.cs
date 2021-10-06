using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcquantitylength.htm" />
	/// </summary>
	public class IfcQuantityLength : IfcPhysicalSimpleQuantity
    {
	    /// <summary>
	    ///     Construct a IfcQuantityLength with all required attributes.
	    /// </summary>
	    public IfcQuantityLength(IfcLabel name, IfcLengthMeasure lengthValue) : base(name)
        {
            LengthValue = lengthValue;
        }

	    /// <summary>
	    ///     Construct a IfcQuantityLength with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcQuantityLength(IfcLabel name, IfcText description, IfcNamedUnit unit, IfcLengthMeasure lengthValue,
            IfcLabel formula) : base(name, description, unit)
        {
            LengthValue = lengthValue;
            Formula = formula;
        }

        public IfcLengthMeasure LengthValue { get; set; }
        public IfcLabel Formula { get; set; } // optional

        public new static IfcQuantityLength FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcQuantityLength>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Unit != null ? Unit.ToStepValue() : "$",
	            LengthValue != null ? LengthValue.ToStepValue() : "$",
	            Formula != null ? Formula.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}