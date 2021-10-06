using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccartesiantransformationoperator2d.htm" />
	/// </summary>
	public class IfcCartesianTransformationOperator2D : IfcCartesianTransformationOperator
    {
	    /// <summary>
	    ///     Construct a IfcCartesianTransformationOperator2D with all required attributes.
	    /// </summary>
	    public IfcCartesianTransformationOperator2D(IfcCartesianPoint localOrigin) : base(localOrigin)
        {
        }

	    /// <summary>
	    ///     Construct a IfcCartesianTransformationOperator2D with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCartesianTransformationOperator2D(IfcDirection axis1, IfcDirection axis2,
            IfcCartesianPoint localOrigin, IfcReal scale) : base(axis1, axis2, localOrigin, scale)
        {
        }

        [JsonIgnore]
        public List<IfcDirection> U =>
            throw new NotImplementedException("Derived property logic has been implemented for U."); // derived

        public new static IfcCartesianTransformationOperator2D FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCartesianTransformationOperator2D>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Axis1 != null ? Axis1.ToStepValue() : "$",
	            Axis2 != null ? Axis2.ToStepValue() : "$",
	            LocalOrigin != null ? LocalOrigin.ToStepValue() : "$",
	            Scale != null ? Scale.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}