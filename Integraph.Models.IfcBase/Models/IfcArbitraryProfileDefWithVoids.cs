using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcarbitraryprofiledefwithvoids.htm" />
	/// </summary>
	public class IfcArbitraryProfileDefWithVoids : IfcArbitraryClosedProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcArbitraryProfileDefWithVoids with all required attributes.
	    /// </summary>
	    public IfcArbitraryProfileDefWithVoids(IfcProfileTypeEnum profileType, IfcCurve outerCurve,
            List<IfcCurve> innerCurves) : base(profileType, outerCurve)
        {
            InnerCurves = innerCurves;
        }

	    /// <summary>
	    ///     Construct a IfcArbitraryProfileDefWithVoids with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcArbitraryProfileDefWithVoids(IfcProfileTypeEnum profileType, IfcLabel profileName,
            IfcCurve outerCurve, List<IfcCurve> innerCurves) : base(profileType, profileName, outerCurve)
        {
            InnerCurves = innerCurves;
        }

        public List<IfcCurve> InnerCurves { get; set; }

        public new static IfcArbitraryProfileDefWithVoids FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcArbitraryProfileDefWithVoids>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ProfileType.ToStepValue(),
                ProfileName != null ? ProfileName.ToStepValue() : "$",
                OuterCurve != null ? OuterCurve.ToStepValue() : "$",
                InnerCurves != null ? InnerCurves.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}