using System;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccsgprimitive3d.htm" />
	/// </summary>
	public abstract class IfcCsgPrimitive3D : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcCsgPrimitive3D with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCsgPrimitive3D(IfcAxis2Placement3D position)
        {
            Position = position;
        }

        public IfcAxis2Placement3D Position { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcCsgPrimitive3D FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCsgPrimitive3D>(json);
        }
    }
}