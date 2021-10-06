using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccirclehollowprofiledef.htm" />
	/// </summary>
	public class IfcCircleHollowProfileDef : IfcCircleProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcCircleHollowProfileDef with all required attributes.
	    /// </summary>
	    public IfcCircleHollowProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure radius,
            IfcPositiveLengthMeasure wallThickness) : base(profileType, radius)
        {
            WallThickness = wallThickness;
        }

	    /// <summary>
	    ///     Construct a IfcCircleHollowProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCircleHollowProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName,
            IfcAxis2Placement2D position, IfcPositiveLengthMeasure radius, IfcPositiveLengthMeasure wallThickness) :
            base(profileType, profileName, position, radius)
        {
            WallThickness = wallThickness;
        }

        public IfcPositiveLengthMeasure WallThickness { get; set; }

        public new static IfcCircleHollowProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCircleHollowProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ProfileType.ToStepValue(),
                ProfileName != null ? ProfileName.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                Radius != null ? Radius.ToStepValue() : "$",
                WallThickness != null ? WallThickness.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}