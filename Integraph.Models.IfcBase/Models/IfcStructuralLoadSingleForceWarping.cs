using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralloadsingleforcewarping.htm" />
	/// </summary>
	public class IfcStructuralLoadSingleForceWarping : IfcStructuralLoadSingleForce
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLoadSingleForceWarping with all required attributes.
	    /// </summary>
	    public IfcStructuralLoadSingleForceWarping()
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLoadSingleForceWarping with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLoadSingleForceWarping(IfcLabel name, IfcForceMeasure forceX, IfcForceMeasure forceY,
            IfcForceMeasure forceZ, IfcTorqueMeasure momentX, IfcTorqueMeasure momentY, IfcTorqueMeasure momentZ,
            IfcWarpingMomentMeasure warpingMoment) : base(name, forceX, forceY, forceZ, momentX, momentY, momentZ)
        {
            WarpingMoment = warpingMoment;
        }

        public IfcWarpingMomentMeasure WarpingMoment { get; set; } // optional

        public new static IfcStructuralLoadSingleForceWarping FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLoadSingleForceWarping>(json);
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
	            MomentZ != null ? MomentZ.ToStepValue() : "$",
	            WarpingMoment != null ? WarpingMoment.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}