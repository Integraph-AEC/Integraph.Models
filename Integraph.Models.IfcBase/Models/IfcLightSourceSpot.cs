using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclightsourcespot.htm" />
	/// </summary>
	public class IfcLightSourceSpot : IfcLightSourcePositional
    {
	    /// <summary>
	    ///     Construct a IfcLightSourceSpot with all required attributes.
	    /// </summary>
	    public IfcLightSourceSpot(IfcColourRgb lightColour, IfcCartesianPoint position, IfcPositiveLengthMeasure radius,
            IfcReal constantAttenuation, IfcReal distanceAttenuation, IfcReal quadricAttenuation,
            IfcDirection orientation, IfcPositivePlaneAngleMeasure spreadAngle,
            IfcPositivePlaneAngleMeasure beamWidthAngle) : base(lightColour, position, radius, constantAttenuation,
            distanceAttenuation, quadricAttenuation)
        {
            Orientation = orientation;
            SpreadAngle = spreadAngle;
            BeamWidthAngle = beamWidthAngle;
        }

	    /// <summary>
	    ///     Construct a IfcLightSourceSpot with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLightSourceSpot(IfcLabel name, IfcColourRgb lightColour, IfcNormalisedRatioMeasure ambientIntensity,
            IfcNormalisedRatioMeasure intensity, IfcCartesianPoint position, IfcPositiveLengthMeasure radius,
            IfcReal constantAttenuation, IfcReal distanceAttenuation, IfcReal quadricAttenuation,
            IfcDirection orientation, IfcReal concentrationExponent, IfcPositivePlaneAngleMeasure spreadAngle,
            IfcPositivePlaneAngleMeasure beamWidthAngle) : base(name, lightColour, ambientIntensity, intensity,
            position, radius, constantAttenuation, distanceAttenuation, quadricAttenuation)
        {
            Orientation = orientation;
            ConcentrationExponent = concentrationExponent;
            SpreadAngle = spreadAngle;
            BeamWidthAngle = beamWidthAngle;
        }

        public IfcDirection Orientation { get; set; }
        public IfcReal ConcentrationExponent { get; set; } // optional
        public IfcPositivePlaneAngleMeasure SpreadAngle { get; set; }
        public IfcPositivePlaneAngleMeasure BeamWidthAngle { get; set; }

        public new static IfcLightSourceSpot FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLightSourceSpot>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                LightColour != null ? LightColour.ToStepValue() : "$",
                AmbientIntensity != null ? AmbientIntensity.ToStepValue() : "$",
                Intensity != null ? Intensity.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                Radius != null ? Radius.ToStepValue() : "$",
                ConstantAttenuation != null ? ConstantAttenuation.ToStepValue() : "$",
                DistanceAttenuation != null ? DistanceAttenuation.ToStepValue() : "$",
                QuadricAttenuation != null ? QuadricAttenuation.ToStepValue() : "$",
                Orientation != null ? Orientation.ToStepValue() : "$",
                ConcentrationExponent != null ? ConcentrationExponent.ToStepValue() : "$",
                SpreadAngle != null ? SpreadAngle.ToStepValue() : "$",
                BeamWidthAngle != null ? BeamWidthAngle.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}