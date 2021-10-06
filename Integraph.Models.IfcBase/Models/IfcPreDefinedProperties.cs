using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpredefinedproperties.htm" />
	/// </summary>
	public abstract class IfcPreDefinedProperties : IfcPropertyAbstraction
    {
	    /// <summary>
	    ///     Construct a IfcPreDefinedProperties with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPreDefinedProperties()
        {
        }

        public new static IfcPreDefinedProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPreDefinedProperties>(json);
        }
    }
}