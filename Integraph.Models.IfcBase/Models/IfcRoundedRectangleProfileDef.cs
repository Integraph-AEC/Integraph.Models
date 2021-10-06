using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcroundedrectangleprofiledef.htm" />
	/// </summary>
	public class IfcRoundedRectangleProfileDef : IfcRectangleProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcRoundedRectangleProfileDef with all required attributes.
	    /// </summary>
	    public IfcRoundedRectangleProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure xDim,
            IfcPositiveLengthMeasure yDim, IfcPositiveLengthMeasure roundingRadius) : base(profileType, xDim, yDim)
        {
            RoundingRadius = roundingRadius;
        }

	    /// <summary>
	    ///     Construct a IfcRoundedRectangleProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRoundedRectangleProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName,
            IfcAxis2Placement2D position, IfcPositiveLengthMeasure xDim, IfcPositiveLengthMeasure yDim,
            IfcPositiveLengthMeasure roundingRadius) : base(profileType, profileName, position, xDim, yDim)
        {
            RoundingRadius = roundingRadius;
        }

        public IfcPositiveLengthMeasure RoundingRadius { get; set; }

        public new static IfcRoundedRectangleProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRoundedRectangleProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ProfileType.ToStepValue(),
                ProfileName != null ? ProfileName.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                XDim != null ? XDim.ToStepValue() : "$",
                YDim != null ? YDim.ToStepValue() : "$",
                RoundingRadius != null ? RoundingRadius.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}