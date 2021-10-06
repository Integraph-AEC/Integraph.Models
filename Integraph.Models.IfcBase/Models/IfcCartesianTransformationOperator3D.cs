using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccartesiantransformationoperator3d.htm" />
	/// </summary>
	public class IfcCartesianTransformationOperator3D : IfcCartesianTransformationOperator
    {
	    /// <summary>
	    ///     Construct a IfcCartesianTransformationOperator3D with all required attributes.
	    /// </summary>
	    public IfcCartesianTransformationOperator3D(IfcCartesianPoint localOrigin) : base(localOrigin)
        {
        }

	    /// <summary>
	    ///     Construct a IfcCartesianTransformationOperator3D with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCartesianTransformationOperator3D(IfcDirection axis1, IfcDirection axis2,
            IfcCartesianPoint localOrigin, IfcReal scale, IfcDirection axis3) : base(axis1, axis2, localOrigin, scale)
        {
            Axis3 = axis3;
        }

        public IfcDirection Axis3 { get; set; } // optional

        [JsonIgnore]
        public List<IfcDirection> U =>
            throw new NotImplementedException("Derived property logic has been implemented for U."); // derived

        public new static IfcCartesianTransformationOperator3D FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCartesianTransformationOperator3D>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Axis1 != null ? Axis1.ToStepValue() : "$",
	            Axis2 != null ? Axis2.ToStepValue() : "$",
	            LocalOrigin != null ? LocalOrigin.ToStepValue() : "$",
	            Scale != null ? Scale.ToStepValue() : "$",
	            Axis3 != null ? Axis3.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}