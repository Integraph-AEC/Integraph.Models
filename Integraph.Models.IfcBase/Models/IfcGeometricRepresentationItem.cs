using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcgeometricrepresentationitem.htm" />
	/// </summary>
	public abstract class IfcGeometricRepresentationItem : IfcRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcGeometricRepresentationItem with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcGeometricRepresentationItem()
        {
        }

        public new static IfcGeometricRepresentationItem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcGeometricRepresentationItem>(json);
        }
    }
}