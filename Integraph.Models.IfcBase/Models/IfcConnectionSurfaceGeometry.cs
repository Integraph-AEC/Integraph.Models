using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconnectionsurfacegeometry.htm" />
	/// </summary>
	public class IfcConnectionSurfaceGeometry : IfcConnectionGeometry
    {
	    /// <summary>
	    ///     Construct a IfcConnectionSurfaceGeometry with all required attributes.
	    /// </summary>
	    public IfcConnectionSurfaceGeometry(IfcSurfaceOrFaceSurface surfaceOnRelatingElement)
        {
            SurfaceOnRelatingElement = surfaceOnRelatingElement;
        }

	    /// <summary>
	    ///     Construct a IfcConnectionSurfaceGeometry with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConnectionSurfaceGeometry(IfcSurfaceOrFaceSurface surfaceOnRelatingElement,
            IfcSurfaceOrFaceSurface surfaceOnRelatedElement)
        {
            SurfaceOnRelatingElement = surfaceOnRelatingElement;
            SurfaceOnRelatedElement = surfaceOnRelatedElement;
        }

        public IfcSurfaceOrFaceSurface SurfaceOnRelatingElement { get; set; }
        public IfcSurfaceOrFaceSurface SurfaceOnRelatedElement { get; set; } // optional

        public new static IfcConnectionSurfaceGeometry FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConnectionSurfaceGeometry>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            SurfaceOnRelatingElement != null ? SurfaceOnRelatingElement.ToStepValue() : "$",
	            SurfaceOnRelatedElement != null ? SurfaceOnRelatedElement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}