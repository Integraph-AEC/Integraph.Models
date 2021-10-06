using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcasymmetricishapeprofiledef.htm" />
	/// </summary>
	public class IfcAsymmetricIShapeProfileDef : IfcParameterizedProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcAsymmetricIShapeProfileDef with all required attributes.
	    /// </summary>
	    public IfcAsymmetricIShapeProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure bottomFlangeWidth,
            IfcPositiveLengthMeasure overallDepth, IfcPositiveLengthMeasure webThickness,
            IfcPositiveLengthMeasure bottomFlangeThickness, IfcPositiveLengthMeasure topFlangeWidth) : base(profileType)
        {
            BottomFlangeWidth = bottomFlangeWidth;
            OverallDepth = overallDepth;
            WebThickness = webThickness;
            BottomFlangeThickness = bottomFlangeThickness;
            TopFlangeWidth = topFlangeWidth;
        }

	    /// <summary>
	    ///     Construct a IfcAsymmetricIShapeProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcAsymmetricIShapeProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName,
            IfcAxis2Placement2D position, IfcPositiveLengthMeasure bottomFlangeWidth,
            IfcPositiveLengthMeasure overallDepth, IfcPositiveLengthMeasure webThickness,
            IfcPositiveLengthMeasure bottomFlangeThickness, IfcNonNegativeLengthMeasure bottomFlangeFilletRadius,
            IfcPositiveLengthMeasure topFlangeWidth, IfcPositiveLengthMeasure topFlangeThickness,
            IfcNonNegativeLengthMeasure topFlangeFilletRadius, IfcNonNegativeLengthMeasure bottomFlangeEdgeRadius,
            IfcPlaneAngleMeasure bottomFlangeSlope, IfcNonNegativeLengthMeasure topFlangeEdgeRadius,
            IfcPlaneAngleMeasure topFlangeSlope) : base(profileType, profileName, position)
        {
            BottomFlangeWidth = bottomFlangeWidth;
            OverallDepth = overallDepth;
            WebThickness = webThickness;
            BottomFlangeThickness = bottomFlangeThickness;
            BottomFlangeFilletRadius = bottomFlangeFilletRadius;
            TopFlangeWidth = topFlangeWidth;
            TopFlangeThickness = topFlangeThickness;
            TopFlangeFilletRadius = topFlangeFilletRadius;
            BottomFlangeEdgeRadius = bottomFlangeEdgeRadius;
            BottomFlangeSlope = bottomFlangeSlope;
            TopFlangeEdgeRadius = topFlangeEdgeRadius;
            TopFlangeSlope = topFlangeSlope;
        }

        public IfcPositiveLengthMeasure BottomFlangeWidth { get; set; }
        public IfcPositiveLengthMeasure OverallDepth { get; set; }
        public IfcPositiveLengthMeasure WebThickness { get; set; }
        public IfcPositiveLengthMeasure BottomFlangeThickness { get; set; }
        public IfcNonNegativeLengthMeasure BottomFlangeFilletRadius { get; set; } // optional
        public IfcPositiveLengthMeasure TopFlangeWidth { get; set; }
        public IfcPositiveLengthMeasure TopFlangeThickness { get; set; } // optional
        public IfcNonNegativeLengthMeasure TopFlangeFilletRadius { get; set; } // optional
        public IfcNonNegativeLengthMeasure BottomFlangeEdgeRadius { get; set; } // optional
        public IfcPlaneAngleMeasure BottomFlangeSlope { get; set; } // optional
        public IfcNonNegativeLengthMeasure TopFlangeEdgeRadius { get; set; } // optional
        public IfcPlaneAngleMeasure TopFlangeSlope { get; set; } // optional

        public new static IfcAsymmetricIShapeProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAsymmetricIShapeProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ProfileType.ToStepValue(),
                ProfileName != null ? ProfileName.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                BottomFlangeWidth != null ? BottomFlangeWidth.ToStepValue() : "$",
                OverallDepth != null ? OverallDepth.ToStepValue() : "$",
                WebThickness != null ? WebThickness.ToStepValue() : "$",
                BottomFlangeThickness != null ? BottomFlangeThickness.ToStepValue() : "$",
                BottomFlangeFilletRadius != null ? BottomFlangeFilletRadius.ToStepValue() : "$",
                TopFlangeWidth != null ? TopFlangeWidth.ToStepValue() : "$",
                TopFlangeThickness != null ? TopFlangeThickness.ToStepValue() : "$",
                TopFlangeFilletRadius != null ? TopFlangeFilletRadius.ToStepValue() : "$",
                BottomFlangeEdgeRadius != null ? BottomFlangeEdgeRadius.ToStepValue() : "$",
                BottomFlangeSlope != null ? BottomFlangeSlope.ToStepValue() : "$",
                TopFlangeEdgeRadius != null ? TopFlangeEdgeRadius.ToStepValue() : "$",
                TopFlangeSlope != null ? TopFlangeSlope.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}