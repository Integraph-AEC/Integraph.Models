using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccompositecurvesegment.htm" />
	/// </summary>
	public class IfcCompositeCurveSegment : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcCompositeCurveSegment with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCompositeCurveSegment(IfcTransitionCode transition, IfcBoolean sameSense, IfcCurve parentCurve)
        {
            UsingCurves = new List<IfcCompositeCurve>();

            Transition = transition;
            SameSense = sameSense;
            ParentCurve = parentCurve;
        }

        public IfcTransitionCode? Transition { get; set; }
        public IfcBoolean SameSense { get; set; }
        public IfcCurve ParentCurve { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public List<IfcCompositeCurve> UsingCurves { get; set; } // inverse

        public new static IfcCompositeCurveSegment FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCompositeCurveSegment>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Transition != null ? Transition.ToStepValue() : "$",
                SameSense != null ? SameSense.ToStepValue() : "$",
                ParentCurve != null ? ParentCurve.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}