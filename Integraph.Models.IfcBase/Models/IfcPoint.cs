using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpoint.htm" />
	/// </summary>
	public abstract class IfcPoint : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcPoint with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPoint()
        {
        }

        public new static IfcPoint FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPoint>(json);
        }
    }
}