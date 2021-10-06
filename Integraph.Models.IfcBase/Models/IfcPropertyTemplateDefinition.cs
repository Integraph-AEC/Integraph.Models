using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertytemplatedefinition.htm" />
	/// </summary>
	public abstract class IfcPropertyTemplateDefinition : IfcPropertyDefinition
    {
	    /// <summary>
	    ///     Construct a IfcPropertyTemplateDefinition with all required attributes.
	    /// </summary>
	    public IfcPropertyTemplateDefinition(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcPropertyTemplateDefinition with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertyTemplateDefinition(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description) : base(globalId, ownerHistory, name, description)
        {
        }

        public new static IfcPropertyTemplateDefinition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertyTemplateDefinition>(json);
        }
    }
}