using System;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccartesiantransformationoperator.htm" />
	/// </summary>
	public abstract class IfcCartesianTransformationOperator : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcCartesianTransformationOperator with all required attributes.
	    /// </summary>
	    public IfcCartesianTransformationOperator(IfcCartesianPoint localOrigin)
        {
            LocalOrigin = localOrigin;
        }

	    /// <summary>
	    ///     Construct a IfcCartesianTransformationOperator with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCartesianTransformationOperator(IfcDirection axis1, IfcDirection axis2, IfcCartesianPoint localOrigin,
            IfcReal scale)
        {
            Axis1 = axis1;
            Axis2 = axis2;
            LocalOrigin = localOrigin;
            Scale = scale;
        }

        public IfcDirection Axis1 { get; set; } // optional
        public IfcDirection Axis2 { get; set; } // optional
        public IfcCartesianPoint LocalOrigin { get; set; }
        public IfcReal Scale { get; set; } // optional

        [JsonIgnore]
        public IfcReal Scl =>
            throw new NotImplementedException("Derived property logic has been implemented for Scl."); // derived

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcCartesianTransformationOperator FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCartesianTransformationOperator>(json);
        }
    }
}