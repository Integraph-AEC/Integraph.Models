using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifczshapeprofiledef.htm" />
	/// </summary>
	public class IfcZShapeProfileDef : IfcParameterizedProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcZShapeProfileDef with all required attributes.
	    /// </summary>
	    public IfcZShapeProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure depth,
            IfcPositiveLengthMeasure flangeWidth, IfcPositiveLengthMeasure webThickness,
            IfcPositiveLengthMeasure flangeThickness) : base(profileType)
        {
            Depth = depth;
            FlangeWidth = flangeWidth;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
        }

	    /// <summary>
	    ///     Construct a IfcZShapeProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcZShapeProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName, IfcAxis2Placement2D position,
            IfcPositiveLengthMeasure depth, IfcPositiveLengthMeasure flangeWidth, IfcPositiveLengthMeasure webThickness,
            IfcPositiveLengthMeasure flangeThickness, IfcNonNegativeLengthMeasure filletRadius,
            IfcNonNegativeLengthMeasure edgeRadius) : base(profileType, profileName, position)
        {
            Depth = depth;
            FlangeWidth = flangeWidth;
            WebThickness = webThickness;
            FlangeThickness = flangeThickness;
            FilletRadius = filletRadius;
            EdgeRadius = edgeRadius;
        }

        public IfcPositiveLengthMeasure Depth { get; set; }
        public IfcPositiveLengthMeasure FlangeWidth { get; set; }
        public IfcPositiveLengthMeasure WebThickness { get; set; }
        public IfcPositiveLengthMeasure FlangeThickness { get; set; }
        public IfcNonNegativeLengthMeasure FilletRadius { get; set; } // optional
        public IfcNonNegativeLengthMeasure EdgeRadius { get; set; } // optional

        public new static IfcZShapeProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcZShapeProfileDef>(json);
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
                EdgeRadius != null ? EdgeRadius.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}