using System;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccurve.htm" />
	/// </summary>
	public abstract class IfcCurve : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcCurve with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCurve()
        {
        }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcCurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCurve>(json);
        }
    }
}