using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralloadsingledisplacement.htm" />
	/// </summary>
	public class IfcStructuralLoadSingleDisplacement : IfcStructuralLoadStatic
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLoadSingleDisplacement with all required attributes.
	    /// </summary>
	    public IfcStructuralLoadSingleDisplacement()
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLoadSingleDisplacement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLoadSingleDisplacement(IfcLabel name, IfcLengthMeasure displacementX,
            IfcLengthMeasure displacementY, IfcLengthMeasure displacementZ,
            IfcPlaneAngleMeasure rotationalDisplacementRx, IfcPlaneAngleMeasure rotationalDisplacementRy,
            IfcPlaneAngleMeasure rotationalDisplacementRz) : base(name)
        {
            DisplacementX = displacementX;
            DisplacementY = displacementY;
            DisplacementZ = displacementZ;
            RotationalDisplacementRx = rotationalDisplacementRx;
            RotationalDisplacementRy = rotationalDisplacementRy;
            RotationalDisplacementRz = rotationalDisplacementRz;
        }

        public IfcLengthMeasure DisplacementX { get; set; } // optional
        public IfcLengthMeasure DisplacementY { get; set; } // optional
        public IfcLengthMeasure DisplacementZ { get; set; } // optional
        public IfcPlaneAngleMeasure RotationalDisplacementRx { get; set; } // optional
        public IfcPlaneAngleMeasure RotationalDisplacementRy { get; set; } // optional
        public IfcPlaneAngleMeasure RotationalDisplacementRz { get; set; } // optional

        public new static IfcStructuralLoadSingleDisplacement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLoadSingleDisplacement>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            DisplacementX != null ? DisplacementX.ToStepValue() : "$",
	            DisplacementY != null ? DisplacementY.ToStepValue() : "$",
	            DisplacementZ != null ? DisplacementZ.ToStepValue() : "$",
	            RotationalDisplacementRx != null ? RotationalDisplacementRx.ToStepValue() : "$",
	            RotationalDisplacementRy != null ? RotationalDisplacementRy.ToStepValue() : "$",
	            RotationalDisplacementRz != null ? RotationalDisplacementRz.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}