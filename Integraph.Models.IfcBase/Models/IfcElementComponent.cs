using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcelementcomponent.htm" />
	/// </summary>
	public abstract class IfcElementComponent : IfcElement
    {
	    /// <summary>
	    ///     Construct a IfcElementComponent with all required attributes.
	    /// </summary>
	    public IfcElementComponent(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcElementComponent with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcElementComponent(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag) : base(globalId, ownerHistory, name,
            description, objectType, objectPlacement, representation, tag)
        {
        }

        public new static IfcElementComponent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcElementComponent>(json);
        }
    }
}