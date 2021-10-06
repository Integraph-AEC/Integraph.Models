using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcadvancedface.htm" />
	/// </summary>
	public class IfcAdvancedFace : IfcFaceSurface
    {
	    /// <summary>
	    ///     Construct a IfcAdvancedFace with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcAdvancedFace(List<IfcFaceBound> bounds, IfcSurface faceSurface, IfcBoolean sameSense) : base(bounds,
            faceSurface, sameSense)
        {
        }

        public new static IfcAdvancedFace FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAdvancedFace>(json);
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