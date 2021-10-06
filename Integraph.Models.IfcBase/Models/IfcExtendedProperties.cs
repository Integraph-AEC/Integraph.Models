using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcextendedproperties.htm" />
	/// </summary>
	public abstract class IfcExtendedProperties : IfcPropertyAbstraction
    {
	    /// <summary>
	    ///     Construct a IfcExtendedProperties with all required attributes.
	    /// </summary>
	    public IfcExtendedProperties(List<IfcProperty> properties)
        {
            Properties = properties;
        }

	    /// <summary>
	    ///     Construct a IfcExtendedProperties with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcExtendedProperties(IfcIdentifier name, IfcText description, List<IfcProperty> properties)
        {
            Name = name;
            Description = description;
            Properties = properties;
        }

        public IfcIdentifier Name { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public List<IfcProperty> Properties { get; set; }

        public new static IfcExtendedProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcExtendedProperties>(json);
        }
    }
}