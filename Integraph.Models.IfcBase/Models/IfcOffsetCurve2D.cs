using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcoffsetcurve2d.htm" />
	/// </summary>
	public class IfcOffsetCurve2D : IfcCurve
    {
	    /// <summary>
	    ///     Construct a IfcOffsetCurve2D with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcOffsetCurve2D(IfcCurve basisCurve, IfcLengthMeasure distance, IfcLogical selfIntersect)
        {
            BasisCurve = basisCurve;
            Distance = distance;
            SelfIntersect = selfIntersect;
        }

        public IfcCurve BasisCurve { get; set; }
        public IfcLengthMeasure Distance { get; set; }
        public IfcLogical SelfIntersect { get; set; }

        public new static IfcOffsetCurve2D FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcOffsetCurve2D>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            BasisCurve != null ? BasisCurve.ToStepValue() : "$",
	            Distance != null ? Distance.ToStepValue() : "$",
	            SelfIntersect != null ? SelfIntersect.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}