using System;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurface.htm" />
	/// </summary>
	public abstract class IfcSurface : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcSurface with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurface()
        {
        }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcSurface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurface>(json);
        }
    }
}