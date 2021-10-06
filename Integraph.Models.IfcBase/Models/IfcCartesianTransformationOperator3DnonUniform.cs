using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see
	///         href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccartesiantransformationoperator3dnonuniform.htm" />
	/// </summary>
	public class IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D
    {
	    /// <summary>
	    ///     Construct a IfcCartesianTransformationOperator3DnonUniform with all required attributes.
	    /// </summary>
	    public IfcCartesianTransformationOperator3DnonUniform(IfcCartesianPoint localOrigin) : base(localOrigin)
        {
        }

	    /// <summary>
	    ///     Construct a IfcCartesianTransformationOperator3DnonUniform with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCartesianTransformationOperator3DnonUniform(IfcDirection axis1, IfcDirection axis2,
            IfcCartesianPoint localOrigin, IfcReal scale, IfcDirection axis3, IfcReal scale2, IfcReal scale3) : base(
            axis1, axis2, localOrigin, scale, axis3)
        {
            Scale2 = scale2;
            Scale3 = scale3;
        }

        public IfcReal Scale2 { get; set; } // optional
        public IfcReal Scale3 { get; set; } // optional

        [JsonIgnore]
        public IfcReal Scl2 =>
            throw new NotImplementedException("Derived property logic has been implemented for Scl2."); // derived

        [JsonIgnore]
        public IfcReal Scl3 =>
            throw new NotImplementedException("Derived property logic has been implemented for Scl3."); // derived

        public new static IfcCartesianTransformationOperator3DnonUniform FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCartesianTransformationOperator3DnonUniform>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Axis1 != null ? Axis1.ToStepValue() : "$",
                Axis2 != null ? Axis2.ToStepValue() : "$",
                LocalOrigin != null ? LocalOrigin.ToStepValue() : "$",
                Scale != null ? Scale.ToStepValue() : "$",
                Axis3 != null ? Axis3.ToStepValue() : "$",
                Scale2 != null ? Scale2.ToStepValue() : "$",
                Scale3 != null ? Scale3.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}