using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcquantitytime.htm" />
	/// </summary>
	public class IfcQuantityTime : IfcPhysicalSimpleQuantity
    {
	    /// <summary>
	    ///     Construct a IfcQuantityTime with all required attributes.
	    /// </summary>
	    public IfcQuantityTime(IfcLabel name, IfcTimeMeasure timeValue) : base(name)
        {
            TimeValue = timeValue;
        }

	    /// <summary>
	    ///     Construct a IfcQuantityTime with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcQuantityTime(IfcLabel name, IfcText description, IfcNamedUnit unit, IfcTimeMeasure timeValue,
            IfcLabel formula) : base(name, description, unit)
        {
            TimeValue = timeValue;
            Formula = formula;
        }

        public IfcTimeMeasure TimeValue { get; set; }
        public IfcLabel Formula { get; set; } // optional

        public new static IfcQuantityTime FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcQuantityTime>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Unit != null ? Unit.ToStepValue() : "$",
	            TimeValue != null ? TimeValue.ToStepValue() : "$",
	            Formula != null ? Formula.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}