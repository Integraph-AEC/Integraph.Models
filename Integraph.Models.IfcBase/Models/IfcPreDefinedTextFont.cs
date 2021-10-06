using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpredefinedtextfont.htm" />
	/// </summary>
	public abstract class IfcPreDefinedTextFont : IfcPreDefinedItem
    {
	    /// <summary>
	    ///     Construct a IfcPreDefinedTextFont with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPreDefinedTextFont(IfcLabel name) : base(name)
        {
        }

        public new static IfcPreDefinedTextFont FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPreDefinedTextFont>(json);
        }
    }
}