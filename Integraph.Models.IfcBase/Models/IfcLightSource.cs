using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclightsource.htm" />
	/// </summary>
	public abstract class IfcLightSource : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcLightSource with all required attributes.
	    /// </summary>
	    public IfcLightSource(IfcColourRgb lightColour)
        {
            LightColour = lightColour;
        }

	    /// <summary>
	    ///     Construct a IfcLightSource with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLightSource(IfcLabel name, IfcColourRgb lightColour, IfcNormalisedRatioMeasure ambientIntensity,
            IfcNormalisedRatioMeasure intensity)
        {
            Name = name;
            LightColour = lightColour;
            AmbientIntensity = ambientIntensity;
            Intensity = intensity;
        }

        public IfcLabel Name { get; set; } // optional
        public IfcColourRgb LightColour { get; set; }
        public IfcNormalisedRatioMeasure AmbientIntensity { get; set; } // optional
        public IfcNormalisedRatioMeasure Intensity { get; set; } // optional

        public new static IfcLightSource FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLightSource>(json);
        }
    }
}