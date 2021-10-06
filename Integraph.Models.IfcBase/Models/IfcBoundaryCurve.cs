using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboundarycurve.htm" />
	/// </summary>
	public class IfcBoundaryCurve : IfcCompositeCurveOnSurface
    {
	    /// <summary>
	    ///     Construct a IfcBoundaryCurve with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBoundaryCurve(List<IfcCompositeCurveSegment> segments, IfcLogical selfIntersect) : base(segments,
            selfIntersect)
        {
        }

        public new static IfcBoundaryCurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBoundaryCurve>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Segments != null ? Segments.ToStepValue() : "$",
	            SelfIntersect != null ? SelfIntersect.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}