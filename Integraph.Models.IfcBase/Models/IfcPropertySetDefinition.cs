using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertysetdefinition.htm" />
	/// </summary>
	public abstract class IfcPropertySetDefinition : IfcPropertyDefinition
    {
	    /// <summary>
	    ///     Construct a IfcPropertySetDefinition with all required attributes.
	    /// </summary>
	    public IfcPropertySetDefinition(IfcGloballyUniqueId globalId) : base(globalId)
        {
            DefinesType = new List<IfcTypeObject>();
            IsDefinedBy = new List<IfcRelDefinesByTemplate>();
            DefinesOccurrence = new List<IfcRelDefinesByProperties>();
        }

	    /// <summary>
	    ///     Construct a IfcPropertySetDefinition with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertySetDefinition(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description) : base(globalId, ownerHistory, name, description)
        {
            DefinesType = new List<IfcTypeObject>();
            IsDefinedBy = new List<IfcRelDefinesByTemplate>();
            DefinesOccurrence = new List<IfcRelDefinesByProperties>();
        }

        public List<IfcTypeObject> DefinesType { get; set; } // inverse
        public List<IfcRelDefinesByTemplate> IsDefinedBy { get; set; } // inverse
        public List<IfcRelDefinesByProperties> DefinesOccurrence { get; set; } // inverse

        public new static IfcPropertySetDefinition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertySetDefinition>(json);
        }
    }
}