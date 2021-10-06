using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcushapeprofiledef.htm" />
	/// </summary>
	public class IfcUShapeProfileDef : IfcParameterizedProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcUShapeProfileDef with all required attributes.
	    /// </summary>
	    public IfcUShapeProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure depth,
            IfcPositiveLengthMeasure flangeWidth, IfcPositiveLengthMeasure webThickness,
            IfcPositiveLengthMeasure flangeThickness) : base(profileType)
        {
            Depth = depth;
            FlangeWidth = flangeWidth;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
        }

	    /// <summary>
	    ///     Construct a IfcUShapeProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcUShapeProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName, IfcAxis2Placement2D position,
            IfcPositiveLengthMeasure depth, IfcPositiveLengthMeasure flangeWidth, IfcPositiveLengthMeasure webThickness,
            IfcPositiveLengthMeasure flangeThickness, IfcNonNegativeLengthMeasure filletRadius,
            IfcNonNegativeLengthMeasure edgeRadius, IfcPlaneAngleMeasure flangeSlope) : base(profileType, profileName,
            position)
        {
            Depth = depth;
            FlangeWidth = flangeWidth;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
            FilletRadius = filletRadius;
            EdgeRadius = edgeRadius;
            FlangeSlope = flangeSlope;
        }

        public IfcPositiveLengthMeasure Depth { get; set; }
        public IfcPositiveLengthMeasure FlangeWidth { get; set; }
        public IfcPositiveLengthMeasure WebThickness { get; set; }
        public IfcPositiveLengthMeasure FlangeThickness { get; set; }
        public IfcNonNegativeLengthMeasure FilletRadius { get; set; } // optional
        public IfcNonNegativeLengthMeasure EdgeRadius { get; set; } // optional
        public IfcPlaneAngleMeasure FlangeSlope { get; set; } // optional

        public new static IfcUShapeProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcUShapeProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ProfileType.ToStepValue(),
                ProfileName != null ? ProfileName.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                Depth != null ? Depth.ToStepValue() : "$",
                FlangeWidth != null ? FlangeWidth.ToStepValue() : "$",
                WebThickness != null ? WebThickness.ToStepValue() : "$",
                FlangeThickness != null ? FlangeThickness.ToStepValue() : "$",
                FilletRadius != null ? FilletRadius.ToStepValue() : "$",
                EdgeRadius != null ? EdgeRadius.ToStepValue() : "$",
                FlangeSlope != null ? FlangeSlope.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}