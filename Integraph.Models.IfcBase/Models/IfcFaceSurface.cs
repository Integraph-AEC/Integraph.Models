using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfacesurface.htm" />
	/// </summary>
	public class IfcFaceSurface : IfcFace
    {
	    /// <summary>
	    ///     Construct a IfcFaceSurface with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFaceSurface(List<IfcFaceBound> bounds, IfcSurface faceSurface, IfcBoolean sameSense) : base(bounds)
        {
            FaceSurface = faceSurface;
            SameSense = sameSense;
        }

        public IfcSurface FaceSurface { get; set; }
        public IfcBoolean SameSense { get; set; }

        public new static IfcFaceSurface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFaceSurface>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Bounds != null ? Bounds.ToStepValue() : "$",
	            FaceSurface != null ? FaceSurface.ToStepValue() : "$",
	            SameSense != null ? SameSense.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}