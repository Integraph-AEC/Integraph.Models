using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrectanglehollowprofiledef.htm" />
	/// </summary>
	public class IfcRectangleHollowProfileDef : IfcRectangleProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcRectangleHollowProfileDef with all required attributes.
	    /// </summary>
	    public IfcRectangleHollowProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure xDim,
            IfcPositiveLengthMeasure yDim, IfcPositiveLengthMeasure wallThickness) : base(profileType, xDim, yDim)
        {
            WallThickness = wallThickness;
        }

	    /// <summary>
	    ///     Construct a IfcRectangleHollowProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRectangleHollowProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName,
            IfcAxis2Placement2D position, IfcPositiveLengthMeasure xDim, IfcPositiveLengthMeasure yDim,
            IfcPositiveLengthMeasure wallThickness, IfcNonNegativeLengthMeasure innerFilletRadius,
            IfcNonNegativeLengthMeasure outerFilletRadius) : base(profileType, profileName, position, xDim, yDim)
        {
            WallThickness = wallThickness;
            InnerFilletRadius = innerFilletRadius;
            OuterFilletRadius = outerFilletRadius;
        }

        public IfcPositiveLengthMeasure WallThickness { get; set; }
        public IfcNonNegativeLengthMeasure InnerFilletRadius { get; set; } // optional
        public IfcNonNegativeLengthMeasure OuterFilletRadius { get; set; } // optional

        public new static IfcRectangleHollowProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRectangleHollowProfileDef>(json);
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
                WallThickness != null ? WallThickness.ToStepValue() : "$",
                InnerFilletRadius != null ? InnerFilletRadius.ToStepValue() : "$",
                OuterFilletRadius != null ? OuterFilletRadius.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}