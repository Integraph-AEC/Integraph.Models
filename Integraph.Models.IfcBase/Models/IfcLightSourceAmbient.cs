using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclightsourceambient.htm" />
	/// </summary>
	public class IfcLightSourceAmbient : IfcLightSource
    {
	    /// <summary>
	    ///     Construct a IfcLightSourceAmbient with all required attributes.
	    /// </summary>
	    public IfcLightSourceAmbient(IfcColourRgb lightColour) : base(lightColour)
        {
        }

	    /// <summary>
	    ///     Construct a IfcLightSourceAmbient with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLightSourceAmbient(IfcLabel name, IfcColourRgb lightColour,
            IfcNormalisedRatioMeasure ambientIntensity, IfcNormalisedRatioMeasure intensity) : base(name, lightColour,
            ambientIntensity, intensity)
        {
        }

        public new static IfcLightSourceAmbient FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLightSourceAmbient>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            LightColour != null ? LightColour.ToStepValue() : "$",
	            AmbientIntensity != null ? AmbientIntensity.ToStepValue() : "$",
	            Intensity != null ? Intensity.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}