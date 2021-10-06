using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfacestylerefraction.htm" />
	/// </summary>
	public class IfcSurfaceStyleRefraction : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcSurfaceStyleRefraction with all required attributes.
	    /// </summary>
	    public IfcSurfaceStyleRefraction()
        {
        }

	    /// <summary>
	    ///     Construct a IfcSurfaceStyleRefraction with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurfaceStyleRefraction(IfcReal refractionIndex, IfcReal dispersionFactor)
        {
            RefractionIndex = refractionIndex;
            DispersionFactor = dispersionFactor;
        }

        public IfcReal RefractionIndex { get; set; } // optional
        public IfcReal DispersionFactor { get; set; } // optional

        public new static IfcSurfaceStyleRefraction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurfaceStyleRefraction>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            RefractionIndex != null ? RefractionIndex.ToStepValue() : "$",
	            DispersionFactor != null ? DispersionFactor.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}