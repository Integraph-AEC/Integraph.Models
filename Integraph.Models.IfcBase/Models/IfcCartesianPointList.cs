using System;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccartesianpointlist.htm" />
	/// </summary>
	public abstract class IfcCartesianPointList : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcCartesianPointList with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCartesianPointList()
        {
        }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcCartesianPointList FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCartesianPointList>(json);
        }
    }
}