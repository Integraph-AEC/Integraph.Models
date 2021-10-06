using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccompositecurve.htm" />
	/// </summary>
	public class IfcCompositeCurve : IfcBoundedCurve
    {
	    /// <summary>
	    ///     Construct a IfcCompositeCurve with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCompositeCurve(List<IfcCompositeCurveSegment> segments, IfcLogical selfIntersect)
        {
            Segments = segments;
            SelfIntersect = selfIntersect;
        }

        public List<IfcCompositeCurveSegment> Segments { get; set; }
        public IfcLogical SelfIntersect { get; set; }

        [JsonIgnore]
        public IfcInteger NSegments =>
            throw new NotImplementedException("Derived property logic has been implemented for NSegments."); // derived

        [JsonIgnore]
        public IfcLogical ClosedCurve =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for ClosedCurve."); // derived

        public new static IfcCompositeCurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCompositeCurve>(json);
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