using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcouterboundarycurve.htm" />
	/// </summary>
	public class IfcOuterBoundaryCurve : IfcBoundaryCurve
    {
	    /// <summary>
	    ///     Construct a IfcOuterBoundaryCurve with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcOuterBoundaryCurve(List<IfcCompositeCurveSegment> segments, IfcLogical selfIntersect) : base(segments,
            selfIntersect)
        {
        }

        public new static IfcOuterBoundaryCurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcOuterBoundaryCurve>(json);
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