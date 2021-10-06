using System;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcplacement.htm" />
	/// </summary>
	public abstract class IfcPlacement : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcPlacement with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPlacement(IfcCartesianPoint location)
        {
            Location = location;
        }

        public IfcCartesianPoint Location { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcPlacement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPlacement>(json);
        }
    }
}