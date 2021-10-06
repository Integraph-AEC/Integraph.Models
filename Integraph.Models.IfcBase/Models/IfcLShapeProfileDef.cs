using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclshapeprofiledef.htm" />
	/// </summary>
	public class IfcLShapeProfileDef : IfcParameterizedProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcLShapeProfileDef with all required attributes.
	    /// </summary>
	    public IfcLShapeProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure depth,
            IfcPositiveLengthMeasure thickness) : base(profileType)
        {
            Depth = depth;
            Thickness = thickness;
        }

	    /// <summary>
	    ///     Construct a IfcLShapeProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLShapeProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName, IfcAxis2Placement2D position,
            IfcPositiveLengthMeasure depth, IfcPositiveLengthMeasure width, IfcPositiveLengthMeasure thickness,
            IfcNonNegativeLengthMeasure filletRadius, IfcNonNegativeLengthMeasure edgeRadius,
            IfcPlaneAngleMeasure legSlope) : base(profileType, profileName, position)
        {
            Depth = depth;
            Width = width;
            Thickness = thickness;
            FilletRadius = filletRadius;
            EdgeRadius = edgeRadius;
            LegSlope = legSlope;
        }

        public IfcPositiveLengthMeasure Depth { get; set; }
        public IfcPositiveLengthMeasure Width { get; set; } // optional
        public IfcPositiveLengthMeasure Thickness { get; set; }
        public IfcNonNegativeLengthMeasure FilletRadius { get; set; } // optional
        public IfcNonNegativeLengthMeasure EdgeRadius { get; set; } // optional
        public IfcPlaneAngleMeasure LegSlope { get; set; } // optional

        public new static IfcLShapeProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLShapeProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ProfileType.ToStepValue(),
                ProfileName != null ? ProfileName.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                Depth != null ? Depth.ToStepValue() : "$",
                Width != null ? Width.ToStepValue() : "$",
                Thickness != null ? Thickness.ToStepValue() : "$",
                FilletRadius != null ? FilletRadius.ToStepValue() : "$",
                EdgeRadius != null ? EdgeRadius.ToStepValue() : "$",
                LegSlope != null ? LegSlope.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}