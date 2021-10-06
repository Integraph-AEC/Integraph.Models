using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralloadsingleforce.htm" />
	/// </summary>
	public class IfcStructuralLoadSingleForce : IfcStructuralLoadStatic
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLoadSingleForce with all required attributes.
	    /// </summary>
	    public IfcStructuralLoadSingleForce()
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLoadSingleForce with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLoadSingleForce(IfcLabel name, IfcForceMeasure forceX, IfcForceMeasure forceY,
            IfcForceMeasure forceZ, IfcTorqueMeasure momentX, IfcTorqueMeasure momentY,
            IfcTorqueMeasure momentZ) : base(name)
        {
            ForceX = forceX;
            ForceY = forceY;
            ForceZ = forceZ;
            MomentX = momentX;
            MomentY = momentY;
            MomentZ = momentZ;
        }

        public IfcForceMeasure ForceX { get; set; } // optional
        public IfcForceMeasure ForceY { get; set; } // optional
        public IfcForceMeasure ForceZ { get; set; } // optional
        public IfcTorqueMeasure MomentX { get; set; } // optional
        public IfcTorqueMeasure MomentY { get; set; } // optional
        public IfcTorqueMeasure MomentZ { get; set; } // optional

        public new static IfcStructuralLoadSingleForce FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLoadSingleForce>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            ForceX != null ? ForceX.ToStepValue() : "$",
	            ForceY != null ? ForceY.ToStepValue() : "$",
	            ForceZ != null ? ForceZ.ToStepValue() : "$",
	            MomentX != null ? MomentX.ToStepValue() : "$",
	            MomentY != null ? MomentY.ToStepValue() : "$",
	            MomentZ != null ? MomentZ.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}