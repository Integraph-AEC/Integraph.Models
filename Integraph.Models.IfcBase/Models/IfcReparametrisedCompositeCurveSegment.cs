using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreparametrisedcompositecurvesegment.htm" />
	/// </summary>
	public class IfcReparametrisedCompositeCurveSegment : IfcCompositeCurveSegment
    {
	    /// <summary>
	    ///     Construct a IfcReparametrisedCompositeCurveSegment with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcReparametrisedCompositeCurveSegment(IfcTransitionCode transition, IfcBoolean sameSense,
            IfcCurve parentCurve, IfcParameterValue paramLength) : base(transition, sameSense, parentCurve)
        {
            ParamLength = paramLength;
        }

        public IfcParameterValue ParamLength { get; set; }

        public new static IfcReparametrisedCompositeCurveSegment FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcReparametrisedCompositeCurveSegment>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Transition != null ? Transition.ToStepValue() : "$",
                SameSense != null ? SameSense.ToStepValue() : "$",
                ParentCurve != null ? ParentCurve.ToStepValue() : "$",
                ParamLength != null ? ParamLength.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}