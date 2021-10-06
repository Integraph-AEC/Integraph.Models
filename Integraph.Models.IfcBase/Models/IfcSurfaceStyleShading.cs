using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfacestyleshading.htm" />
	/// </summary>
	public class IfcSurfaceStyleShading : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcSurfaceStyleShading with all required attributes.
	    /// </summary>
	    public IfcSurfaceStyleShading(IfcColourRgb surfaceColour)
        {
            SurfaceColour = surfaceColour;
        }

	    /// <summary>
	    ///     Construct a IfcSurfaceStyleShading with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurfaceStyleShading(IfcColourRgb surfaceColour, IfcNormalisedRatioMeasure transparency)
        {
            SurfaceColour = surfaceColour;
            Transparency = transparency;
        }

        public IfcColourRgb SurfaceColour { get; set; }
        public IfcNormalisedRatioMeasure Transparency { get; set; } // optional

        public new static IfcSurfaceStyleShading FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurfaceStyleShading>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            SurfaceColour != null ? SurfaceColour.ToStepValue() : "$",
	            Transparency != null ? Transparency.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}