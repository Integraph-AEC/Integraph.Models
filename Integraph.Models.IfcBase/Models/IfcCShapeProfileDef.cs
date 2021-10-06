using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccshapeprofiledef.htm" />
	/// </summary>
	public class IfcCShapeProfileDef : IfcParameterizedProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcCShapeProfileDef with all required attributes.
	    /// </summary>
	    public IfcCShapeProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure depth,
            IfcPositiveLengthMeasure width, IfcPositiveLengthMeasure wallThickness,
            IfcPositiveLengthMeasure girth) : base(profileType)
        {
            Depth = depth;
            Width = width;
            WallThickness = wallThickness;
            Girth = girth;
        }

	    /// <summary>
	    ///     Construct a IfcCShapeProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCShapeProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName, IfcAxis2Placement2D position,
            IfcPositiveLengthMeasure depth, IfcPositiveLengthMeasure width, IfcPositiveLengthMeasure wallThickness,
            IfcPositiveLengthMeasure girth, IfcNonNegativeLengthMeasure internalFilletRadius) : base(profileType,
            profileName, position)
        {
            Depth = depth;
            Width = width;
            WallThickness = wallThickness;
            Girth = girth;
            InternalFilletRadius = internalFilletRadius;
        }

        public IfcPositiveLengthMeasure Depth { get; set; }
        public IfcPositiveLengthMeasure Width { get; set; }
        public IfcPositiveLengthMeasure WallThickness { get; set; }
        public IfcPositiveLengthMeasure Girth { get; set; }
        public IfcNonNegativeLengthMeasure InternalFilletRadius { get; set; } // optional

        public new static IfcCShapeProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCShapeProfileDef>(json);
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
                WallThickness != null ? WallThickness.ToStepValue() : "$",
                Girth != null ? Girth.ToStepValue() : "$",
                InternalFilletRadius != null ? InternalFilletRadius.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}