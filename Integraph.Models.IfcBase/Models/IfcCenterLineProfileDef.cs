using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccenterlineprofiledef.htm" />
	/// </summary>
	public class IfcCenterLineProfileDef : IfcArbitraryOpenProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcCenterLineProfileDef with all required attributes.
	    /// </summary>
	    public IfcCenterLineProfileDef(IfcProfileTypeEnum profileType, IfcBoundedCurve curve,
            IfcPositiveLengthMeasure thickness) : base(profileType, curve)
        {
            Thickness = thickness;
        }

	    /// <summary>
	    ///     Construct a IfcCenterLineProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCenterLineProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName, IfcBoundedCurve curve,
            IfcPositiveLengthMeasure thickness) : base(profileType, profileName, curve)
        {
            Thickness = thickness;
        }

        public IfcPositiveLengthMeasure Thickness { get; set; }

        public new static IfcCenterLineProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCenterLineProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ProfileType.ToStepValue(),
                ProfileName != null ? ProfileName.ToStepValue() : "$",
                Curve != null ? Curve.ToStepValue() : "$",
                Thickness != null ? Thickness.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}