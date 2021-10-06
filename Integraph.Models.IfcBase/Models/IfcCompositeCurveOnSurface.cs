using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccompositecurveonsurface.htm" />
	/// </summary>
	public class IfcCompositeCurveOnSurface : IfcCompositeCurve
    {
	    /// <summary>
	    ///     Construct a IfcCompositeCurveOnSurface with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCompositeCurveOnSurface(List<IfcCompositeCurveSegment> segments, IfcLogical selfIntersect) : base(
            segments, selfIntersect)
        {
        }

        [JsonIgnore]
        public List<IfcSurface> BasisSurface =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for BasisSurface."); // derived

        public new static IfcCompositeCurveOnSurface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCompositeCurveOnSurface>(json);
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