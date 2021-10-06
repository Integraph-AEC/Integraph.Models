using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctessellateditem.htm" />
	/// </summary>
	public abstract class IfcTessellatedItem : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcTessellatedItem with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTessellatedItem()
        {
        }

        public new static IfcTessellatedItem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTessellatedItem>(json);
        }
    }
}