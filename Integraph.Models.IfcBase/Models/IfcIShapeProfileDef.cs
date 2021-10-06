using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcishapeprofiledef.htm" />
	/// </summary>
	public class IfcIShapeProfileDef : IfcParameterizedProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcIShapeProfileDef with all required attributes.
	    /// </summary>
	    public IfcIShapeProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure overallWidth,
            IfcPositiveLengthMeasure overallDepth, IfcPositiveLengthMeasure webThickness,
            IfcPositiveLengthMeasure flangeThickness) : base(profileType)
        {
            OverallWidth = overallWidth;
            OverallDepth = overallDepth;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
        }

	    /// <summary>
	    ///     Construct a IfcIShapeProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcIShapeProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName, IfcAxis2Placement2D position,
            IfcPositiveLengthMeasure overallWidth, IfcPositiveLengthMeasure overallDepth,
            IfcPositiveLengthMeasure webThickness, IfcPositiveLengthMeasure flangeThickness,
            IfcNonNegativeLengthMeasure filletRadius, IfcNonNegativeLengthMeasure flangeEdgeRadius,
            IfcPlaneAngleMeasure flangeSlope) : base(profileType, profileName, position)
        {
            OverallWidth = overallWidth;
            OverallDepth = overallDepth;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
            FilletRadius = filletRadius;
            FlangeEdgeRadius = flangeEdgeRadius;
            FlangeSlope = flangeSlope;
        }

        public IfcPositiveLengthMeasure OverallWidth { get; set; }
        public IfcPositiveLengthMeasure OverallDepth { get; set; }
        public IfcPositiveLengthMeasure WebThickness { get; set; }
        public IfcPositiveLengthMeasure FlangeThickness { get; set; }
        public IfcNonNegativeLengthMeasure FilletRadius { get; set; } // optional
        public IfcNonNegativeLengthMeasure FlangeEdgeRadius { get; set; } // optional
        public IfcPlaneAngleMeasure FlangeSlope { get; set; } // optional

        public new static IfcIShapeProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIShapeProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ProfileType.ToStepValue(),
                ProfileName != null ? ProfileName.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                OverallWidth != null ? OverallWidth.ToStepValue() : "$",
                OverallDepth != null ? OverallDepth.ToStepValue() : "$",
                WebThickness != null ? WebThickness.ToStepValue() : "$",
                FlangeThickness != null ? FlangeThickness.ToStepValue() : "$",
                FilletRadius != null ? FilletRadius.ToStepValue() : "$",
                FlangeEdgeRadius != null ? FlangeEdgeRadius.ToStepValue() : "$",
                FlangeSlope != null ? FlangeSlope.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}