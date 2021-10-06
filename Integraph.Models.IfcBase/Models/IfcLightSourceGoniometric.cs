using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclightsourcegoniometric.htm" />
	/// </summary>
	public class IfcLightSourceGoniometric : IfcLightSource
    {
	    /// <summary>
	    ///     Construct a IfcLightSourceGoniometric with all required attributes.
	    /// </summary>
	    public IfcLightSourceGoniometric(IfcColourRgb lightColour, IfcAxis2Placement3D position,
            IfcThermodynamicTemperatureMeasure colourTemperature, IfcLuminousFluxMeasure luminousFlux,
            IfcLightEmissionSourceEnum lightEmissionSource,
            IfcLightDistributionDataSourceSelect lightDistributionDataSource) : base(lightColour)
        {
            Position = position;
            ColourTemperature = colourTemperature;
            LuminousFlux = luminousFlux;
            LightEmissionSource = lightEmissionSource;
            LightDistributionDataSource = lightDistributionDataSource;
        }

	    /// <summary>
	    ///     Construct a IfcLightSourceGoniometric with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLightSourceGoniometric(IfcLabel name, IfcColourRgb lightColour,
            IfcNormalisedRatioMeasure ambientIntensity, IfcNormalisedRatioMeasure intensity,
            IfcAxis2Placement3D position, IfcColourRgb colourAppearance,
            IfcThermodynamicTemperatureMeasure colourTemperature, IfcLuminousFluxMeasure luminousFlux,
            IfcLightEmissionSourceEnum lightEmissionSource,
            IfcLightDistributionDataSourceSelect lightDistributionDataSource) : base(name, lightColour,
            ambientIntensity, intensity)
        {
            Position = position;
            ColourAppearance = colourAppearance;
            ColourTemperature = colourTemperature;
            LuminousFlux = luminousFlux;
            LightEmissionSource = lightEmissionSource;
            LightDistributionDataSource = lightDistributionDataSource;
        }

        public IfcAxis2Placement3D Position { get; set; }
        public IfcColourRgb ColourAppearance { get; set; } // optional
        public IfcThermodynamicTemperatureMeasure ColourTemperature { get; set; }
        public IfcLuminousFluxMeasure LuminousFlux { get; set; }
        public IfcLightEmissionSourceEnum? LightEmissionSource { get; set; }
        public IfcLightDistributionDataSourceSelect LightDistributionDataSource { get; set; }

        public new static IfcLightSourceGoniometric FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLightSourceGoniometric>(json);
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
                ColourAppearance != null ? ColourAppearance.ToStepValue() : "$",
                ColourTemperature != null ? ColourTemperature.ToStepValue() : "$",
                LuminousFlux != null ? LuminousFlux.ToStepValue() : "$",
                LightEmissionSource.ToStepValue(),
                LightDistributionDataSource != null ? LightDistributionDataSource.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}