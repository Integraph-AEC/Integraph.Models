using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclightsourcedirectional.htm" />
	/// </summary>
	public class IfcLightSourceDirectional : IfcLightSource
    {
	    /// <summary>
	    ///     Construct a IfcLightSourceDirectional with all required attributes.
	    /// </summary>
	    public IfcLightSourceDirectional(IfcColourRgb lightColour, IfcDirection orientation) : base(lightColour)
        {
            Orientation = orientation;
        }

	    /// <summary>
	    ///     Construct a IfcLightSourceDirectional with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLightSourceDirectional(IfcLabel name, IfcColourRgb lightColour,
            IfcNormalisedRatioMeasure ambientIntensity, IfcNormalisedRatioMeasure intensity, IfcDirection orientation) :
            base(name, lightColour, ambientIntensity, intensity)
        {
            Orientation = orientation;
        }

        public IfcDirection Orientation { get; set; }

        public new static IfcLightSourceDirectional FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLightSourceDirectional>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            LightColour != null ? LightColour.ToStepValue() : "$",
	            AmbientIntensity != null ? AmbientIntensity.ToStepValue() : "$",
	            Intensity != null ? Intensity.ToStepValue() : "$",
	            Orientation != null ? Orientation.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}