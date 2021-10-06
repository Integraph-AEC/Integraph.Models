using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcphysicalsimplequantity.htm" />
	/// </summary>
	public abstract class IfcPhysicalSimpleQuantity : IfcPhysicalQuantity
    {
	    /// <summary>
	    ///     Construct a IfcPhysicalSimpleQuantity with all required attributes.
	    /// </summary>
	    public IfcPhysicalSimpleQuantity(IfcLabel name) : base(name)
        {
        }

	    /// <summary>
	    ///     Construct a IfcPhysicalSimpleQuantity with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPhysicalSimpleQuantity(IfcLabel name, IfcText description, IfcNamedUnit unit) : base(name,
            description)
        {
            Unit = unit;
        }

        public IfcNamedUnit Unit { get; set; } // optional

        public new static IfcPhysicalSimpleQuantity FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPhysicalSimpleQuantity>(json);
        }
    }
}