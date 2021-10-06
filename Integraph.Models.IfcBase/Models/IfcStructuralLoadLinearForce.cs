using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralloadlinearforce.htm" />
	/// </summary>
	public class IfcStructuralLoadLinearForce : IfcStructuralLoadStatic
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLoadLinearForce with all required attributes.
	    /// </summary>
	    public IfcStructuralLoadLinearForce()
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLoadLinearForce with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLoadLinearForce(IfcLabel name, IfcLinearForceMeasure linearForceX,
            IfcLinearForceMeasure linearForceY, IfcLinearForceMeasure linearForceZ,
            IfcLinearMomentMeasure linearMomentX, IfcLinearMomentMeasure linearMomentY,
            IfcLinearMomentMeasure linearMomentZ) : base(name)
        {
            LinearForceX = linearForceX;
            LinearForceY = linearForceY;
            LinearForceZ = linearForceZ;
            LinearMomentX = linearMomentX;
            LinearMomentY = linearMomentY;
            LinearMomentZ = linearMomentZ;
        }

        public IfcLinearForceMeasure LinearForceX { get; set; } // optional
        public IfcLinearForceMeasure LinearForceY { get; set; } // optional
        public IfcLinearForceMeasure LinearForceZ { get; set; } // optional
        public IfcLinearMomentMeasure LinearMomentX { get; set; } // optional
        public IfcLinearMomentMeasure LinearMomentY { get; set; } // optional
        public IfcLinearMomentMeasure LinearMomentZ { get; set; } // optional

        public new static IfcStructuralLoadLinearForce FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLoadLinearForce>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            LinearForceX != null ? LinearForceX.ToStepValue() : "$",
	            LinearForceY != null ? LinearForceY.ToStepValue() : "$",
	            LinearForceZ != null ? LinearForceZ.ToStepValue() : "$",
	            LinearMomentX != null ? LinearMomentX.ToStepValue() : "$",
	            LinearMomentY != null ? LinearMomentY.ToStepValue() : "$",
	            LinearMomentZ != null ? LinearMomentZ.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}