using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbuildingelement.htm" />
	/// </summary>
	public abstract class IfcBuildingElement : IfcElement
    {
	    /// <summary>
	    ///     Construct a IfcBuildingElement with all required attributes.
	    /// </summary>
	    public IfcBuildingElement(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcBuildingElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBuildingElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag) : base(globalId, ownerHistory, name,
            description, objectType, objectPlacement, representation, tag)
        {
        }

        public new static IfcBuildingElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBuildingElement>(json);
        }
    }
}