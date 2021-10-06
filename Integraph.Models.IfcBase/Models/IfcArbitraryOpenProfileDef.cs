using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcarbitraryopenprofiledef.htm" />
	/// </summary>
	public class IfcArbitraryOpenProfileDef : IfcProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcArbitraryOpenProfileDef with all required attributes.
	    /// </summary>
	    public IfcArbitraryOpenProfileDef(IfcProfileTypeEnum profileType, IfcBoundedCurve curve) : base(profileType)
        {
            Curve = curve;
        }

	    /// <summary>
	    ///     Construct a IfcArbitraryOpenProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcArbitraryOpenProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName, IfcBoundedCurve curve) :
            base(profileType, profileName)
        {
            Curve = curve;
        }

        public IfcBoundedCurve Curve { get; set; }

        public new static IfcArbitraryOpenProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcArbitraryOpenProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            ProfileType.ToStepValue(),
	            ProfileName != null ? ProfileName.ToStepValue() : "$",
	            Curve != null ? Curve.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}