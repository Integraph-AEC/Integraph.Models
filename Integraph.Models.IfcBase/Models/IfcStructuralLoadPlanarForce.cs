using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralloadplanarforce.htm" />
	/// </summary>
	public class IfcStructuralLoadPlanarForce : IfcStructuralLoadStatic
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLoadPlanarForce with all required attributes.
	    /// </summary>
	    public IfcStructuralLoadPlanarForce()
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLoadPlanarForce with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLoadPlanarForce(IfcLabel name, IfcPlanarForceMeasure planarForceX,
            IfcPlanarForceMeasure planarForceY, IfcPlanarForceMeasure planarForceZ) : base(name)
        {
            PlanarForceX = planarForceX;
            PlanarForceY = planarForceY;
            PlanarForceZ = planarForceZ;
        }

        public IfcPlanarForceMeasure PlanarForceX { get; set; } // optional
        public IfcPlanarForceMeasure PlanarForceY { get; set; } // optional
        public IfcPlanarForceMeasure PlanarForceZ { get; set; } // optional

        public new static IfcStructuralLoadPlanarForce FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLoadPlanarForce>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            PlanarForceX != null ? PlanarForceX.ToStepValue() : "$",
	            PlanarForceY != null ? PlanarForceY.ToStepValue() : "$",
	            PlanarForceZ != null ? PlanarForceZ.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}