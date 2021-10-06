using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctopologicalrepresentationitem.htm" />
	/// </summary>
	public abstract class IfcTopologicalRepresentationItem : IfcRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcTopologicalRepresentationItem with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTopologicalRepresentationItem()
        {
        }

        public new static IfcTopologicalRepresentationItem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTopologicalRepresentationItem>(json);
        }
    }
}