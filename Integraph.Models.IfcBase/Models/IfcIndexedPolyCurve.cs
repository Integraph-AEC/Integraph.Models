using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcindexedpolycurve.htm" />
	/// </summary>
	public class IfcIndexedPolyCurve : IfcBoundedCurve
    {
	    /// <summary>
	    ///     Construct a IfcIndexedPolyCurve with all required attributes.
	    /// </summary>
	    public IfcIndexedPolyCurve(IfcCartesianPointList points)
        {
            Segments = new List<IfcSegmentIndexSelect>();

            Points = points;
        }

	    /// <summary>
	    ///     Construct a IfcIndexedPolyCurve with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcIndexedPolyCurve(IfcCartesianPointList points, List<IfcSegmentIndexSelect> segments,
            IfcBoolean selfIntersect)
        {
            Points = points;
            Segments = segments;
            SelfIntersect = selfIntersect;
        }

        public IfcCartesianPointList Points { get; set; }
        public List<IfcSegmentIndexSelect> Segments { get; set; } // optional
        public IfcBoolean SelfIntersect { get; set; } // optional

        public new static IfcIndexedPolyCurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIndexedPolyCurve>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Points != null ? Points.ToStepValue() : "$",
	            Segments != null ? Segments.ToStepValue() : "$",
	            SelfIntersect != null ? SelfIntersect.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}