using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfacestylerendering.htm" />
	/// </summary>
	public class IfcSurfaceStyleRendering : IfcSurfaceStyleShading
    {
	    /// <summary>
	    ///     Construct a IfcSurfaceStyleRendering with all required attributes.
	    /// </summary>
	    public IfcSurfaceStyleRendering(IfcColourRgb surfaceColour, IfcReflectanceMethodEnum reflectanceMethod) : base(
            surfaceColour)
        {
            ReflectanceMethod = reflectanceMethod;
        }

	    /// <summary>
	    ///     Construct a IfcSurfaceStyleRendering with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurfaceStyleRendering(IfcColourRgb surfaceColour, IfcNormalisedRatioMeasure transparency,
            IfcColourOrFactor diffuseColour, IfcColourOrFactor transmissionColour,
            IfcColourOrFactor diffuseTransmissionColour, IfcColourOrFactor reflectionColour,
            IfcColourOrFactor specularColour, IfcSpecularHighlightSelect specularHighlight,
            IfcReflectanceMethodEnum reflectanceMethod) : base(surfaceColour, transparency)
        {
            DiffuseColour = diffuseColour;
            TransmissionColour = transmissionColour;
            DiffuseTransmissionColour = diffuseTransmissionColour;
            ReflectionColour = reflectionColour;
            SpecularColour = specularColour;
            SpecularHighlight = specularHighlight;
            ReflectanceMethod = reflectanceMethod;
        }

        public IfcColourOrFactor DiffuseColour { get; set; } // optional
        public IfcColourOrFactor TransmissionColour { get; set; } // optional
        public IfcColourOrFactor DiffuseTransmissionColour { get; set; } // optional
        public IfcColourOrFactor ReflectionColour { get; set; } // optional
        public IfcColourOrFactor SpecularColour { get; set; } // optional
        public IfcSpecularHighlightSelect SpecularHighlight { get; set; } // optional
        public IfcReflectanceMethodEnum? ReflectanceMethod { get; set; }

        public new static IfcSurfaceStyleRendering FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurfaceStyleRendering>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                SurfaceColour != null ? SurfaceColour.ToStepValue() : "$",
                Transparency != null ? Transparency.ToStepValue() : "$",
                DiffuseColour != null ? DiffuseColour.ToStepValue() : "$",
                TransmissionColour != null ? TransmissionColour.ToStepValue() : "$",
                DiffuseTransmissionColour != null ? DiffuseTransmissionColour.ToStepValue() : "$",
                ReflectionColour != null ? ReflectionColour.ToStepValue() : "$",
                SpecularColour != null ? SpecularColour.ToStepValue() : "$",
                SpecularHighlight != null ? SpecularHighlight.ToStepValue() : "$",
                ReflectanceMethod.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}