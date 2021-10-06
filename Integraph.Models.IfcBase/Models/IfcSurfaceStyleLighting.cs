using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfacestylelighting.htm" />
	/// </summary>
	public class IfcSurfaceStyleLighting : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcSurfaceStyleLighting with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurfaceStyleLighting(IfcColourRgb diffuseTransmissionColour, IfcColourRgb diffuseReflectionColour,
            IfcColourRgb transmissionColour, IfcColourRgb reflectanceColour)
        {
            DiffuseTransmissionColour = diffuseTransmissionColour;
            DiffuseReflectionColour = diffuseReflectionColour;
            TransmissionColour = transmissionColour;
            ReflectanceColour = reflectanceColour;
        }

        public IfcColourRgb DiffuseTransmissionColour { get; set; }
        public IfcColourRgb DiffuseReflectionColour { get; set; }
        public IfcColourRgb TransmissionColour { get; set; }
        public IfcColourRgb ReflectanceColour { get; set; }

        public new static IfcSurfaceStyleLighting FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurfaceStyleLighting>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                DiffuseTransmissionColour != null ? DiffuseTransmissionColour.ToStepValue() : "$",
                DiffuseReflectionColour != null ? DiffuseReflectionColour.ToStepValue() : "$",
                TransmissionColour != null ? TransmissionColour.ToStepValue() : "$",
                ReflectanceColour != null ? ReflectanceColour.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}