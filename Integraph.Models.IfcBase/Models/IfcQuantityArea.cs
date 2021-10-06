using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcquantityarea.htm" />
	/// </summary>
	public class IfcQuantityArea : IfcPhysicalSimpleQuantity
    {
	    /// <summary>
	    ///     Construct a IfcQuantityArea with all required attributes.
	    /// </summary>
	    public IfcQuantityArea(IfcLabel name, IfcAreaMeasure areaValue) : base(name)
        {
            AreaValue = areaValue;
        }

	    /// <summary>
	    ///     Construct a IfcQuantityArea with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcQuantityArea(IfcLabel name, IfcText description, IfcNamedUnit unit, IfcAreaMeasure areaValue,
            IfcLabel formula) : base(name, description, unit)
        {
            AreaValue = areaValue;
            Formula = formula;
        }

        public IfcAreaMeasure AreaValue { get; set; }
        public IfcLabel Formula { get; set; } // optional

        public new static IfcQuantityArea FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcQuantityArea>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Unit != null ? Unit.ToStepValue() : "$",
	            AreaValue != null ? AreaValue.ToStepValue() : "$",
	            Formula != null ? Formula.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}