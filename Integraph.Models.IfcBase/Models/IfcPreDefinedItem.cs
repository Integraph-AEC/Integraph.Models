using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpredefineditem.htm" />
	/// </summary>
	public abstract class IfcPreDefinedItem : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcPreDefinedItem with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPreDefinedItem(IfcLabel name)
        {
            Name = name;
        }

        public IfcLabel Name { get; set; }

        public new static IfcPreDefinedItem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPreDefinedItem>(json);
        }
    }
}