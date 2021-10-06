using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see
	///         href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccartesiantransformationoperator2dnonuniform.htm" />
	/// </summary>
	public class IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D
    {
	    /// <summary>
	    ///     Construct a IfcCartesianTransformationOperator2DnonUniform with all required attributes.
	    /// </summary>
	    public IfcCartesianTransformationOperator2DnonUniform(IfcCartesianPoint localOrigin) : base(localOrigin)
        {
        }

	    /// <summary>
	    ///     Construct a IfcCartesianTransformationOperator2DnonUniform with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCartesianTransformationOperator2DnonUniform(IfcDirection axis1, IfcDirection axis2,
            IfcCartesianPoint localOrigin, IfcReal scale, IfcReal scale2) : base(axis1, axis2, localOrigin, scale)
        {
            Scale2 = scale2;
        }

        public IfcReal Scale2 { get; set; } // optional

        [JsonIgnore]
        public IfcReal Scl2 =>
            throw new NotImplementedException("Derived property logic has been implemented for Scl2."); // derived

        public new static IfcCartesianTransformationOperator2DnonUniform FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCartesianTransformationOperator2DnonUniform>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Axis1 != null ? Axis1.ToStepValue() : "$",
	            Axis2 != null ? Axis2.ToStepValue() : "$",
	            LocalOrigin != null ? LocalOrigin.ToStepValue() : "$",
	            Scale != null ? Scale.ToStepValue() : "$",
	            Scale2 != null ? Scale2.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}