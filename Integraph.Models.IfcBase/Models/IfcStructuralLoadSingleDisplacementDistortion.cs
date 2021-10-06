using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see
	///         href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralloadsingledisplacementdistortion.htm" />
	/// </summary>
	public class IfcStructuralLoadSingleDisplacementDistortion : IfcStructuralLoadSingleDisplacement
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLoadSingleDisplacementDistortion with all required attributes.
	    /// </summary>
	    public IfcStructuralLoadSingleDisplacementDistortion()
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLoadSingleDisplacementDistortion with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLoadSingleDisplacementDistortion(IfcLabel name, IfcLengthMeasure displacementX,
            IfcLengthMeasure displacementY, IfcLengthMeasure displacementZ,
            IfcPlaneAngleMeasure rotationalDisplacementRx, IfcPlaneAngleMeasure rotationalDisplacementRy,
            IfcPlaneAngleMeasure rotationalDisplacementRz, IfcCurvatureMeasure distortion) : base(name, displacementX,
            displacementY, displacementZ, rotationalDisplacementRx, rotationalDisplacementRy, rotationalDisplacementRz)
        {
            Distortion = distortion;
        }

        public IfcCurvatureMeasure Distortion { get; set; } // optional

        public new static IfcStructuralLoadSingleDisplacementDistortion FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLoadSingleDisplacementDistortion>(json);
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
	            RotationalDisplacementRz != null ? RotationalDisplacementRz.ToStepValue() : "$",
	            Distortion != null ? Distortion.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}