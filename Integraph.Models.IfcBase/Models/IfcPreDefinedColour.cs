using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpredefinedcolour.htm" />
	/// </summary>
	public abstract class IfcPreDefinedColour : IfcPreDefinedItem
    {
	    /// <summary>
	    ///     Construct a IfcPreDefinedColour with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPreDefinedColour(IfcLabel name) : base(name)
        {
        }

        public new static IfcPreDefinedColour FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPreDefinedColour>(json);
        }
    }
}