using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsimpleproperty.htm" />
	/// </summary>
	public abstract class IfcSimpleProperty : IfcProperty
    {
	    /// <summary>
	    ///     Construct a IfcSimpleProperty with all required attributes.
	    /// </summary>
	    public IfcSimpleProperty(IfcIdentifier name) : base(name)
        {
        }

	    /// <summary>
	    ///     Construct a IfcSimpleProperty with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSimpleProperty(IfcIdentifier name, IfcText description) : base(name, description)
        {
        }

        public new static IfcSimpleProperty FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSimpleProperty>(json);
        }
    }
}