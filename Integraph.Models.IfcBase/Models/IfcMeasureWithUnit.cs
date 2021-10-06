using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmeasurewithunit.htm" />
	/// </summary>
	public class IfcMeasureWithUnit : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcMeasureWithUnit with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMeasureWithUnit(IfcValue valueComponent, IfcUnit unitComponent)
        {
            ValueComponent = valueComponent;
            UnitComponent = unitComponent;
        }

        public IfcValue ValueComponent { get; set; }
        public IfcUnit UnitComponent { get; set; }

        public static IfcMeasureWithUnit FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMeasureWithUnit>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            ValueComponent != null ? ValueComponent.ToStepValue() : "$",
	            UnitComponent != null ? UnitComponent.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}