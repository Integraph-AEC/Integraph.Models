using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclightsourcepositional.htm" />
	/// </summary>
	public class IfcLightSourcePositional : IfcLightSource
    {
	    /// <summary>
	    ///     Construct a IfcLightSourcePositional with all required attributes.
	    /// </summary>
	    public IfcLightSourcePositional(IfcColourRgb lightColour, IfcCartesianPoint position,
            IfcPositiveLengthMeasure radius, IfcReal constantAttenuation, IfcReal distanceAttenuation,
            IfcReal quadricAttenuation) : base(lightColour)
        {
            Position = position;
            Radius = radius;
            ConstantAttenuation = constantAttenuation;
            DistanceAttenuation = distanceAttenuation;
            QuadricAttenuation = quadricAttenuation;
        }

	    /// <summary>
	    ///     Construct a IfcLightSourcePositional with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLightSourcePositional(IfcLabel name, IfcColourRgb lightColour,
            IfcNormalisedRatioMeasure ambientIntensity, IfcNormalisedRatioMeasure intensity, IfcCartesianPoint position,
            IfcPositiveLengthMeasure radius, IfcReal constantAttenuation, IfcReal distanceAttenuation,
            IfcReal quadricAttenuation) : base(name, lightColour, ambientIntensity, intensity)
        {
            Position = position;
            Radius = radius;
            ConstantAttenuation = constantAttenuation;
            DistanceAttenuation = distanceAttenuation;
            QuadricAttenuation = quadricAttenuation;
        }

        public IfcCartesianPoint Position { get; set; }
        public IfcPositiveLengthMeasure Radius { get; set; }
        public IfcReal ConstantAttenuation { get; set; }
        public IfcReal DistanceAttenuation { get; set; }
        public IfcReal QuadricAttenuation { get; set; }

        public new static IfcLightSourcePositional FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLightSourcePositional>(json);
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
                QuadricAttenuation != null ? QuadricAttenuation.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}