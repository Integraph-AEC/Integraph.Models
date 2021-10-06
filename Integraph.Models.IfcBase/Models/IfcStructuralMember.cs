using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralmember.htm" />
	/// </summary>
	public abstract class IfcStructuralMember : IfcStructuralItem
    {
	    /// <summary>
	    ///     Construct a IfcStructuralMember with all required attributes.
	    /// </summary>
	    public IfcStructuralMember(IfcGloballyUniqueId globalId) : base(globalId)
        {
            ConnectedBy = new List<IfcRelConnectsStructuralMember>();
        }

	    /// <summary>
	    ///     Construct a IfcStructuralMember with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralMember(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation)
        {
            ConnectedBy = new List<IfcRelConnectsStructuralMember>();
        }

        public List<IfcRelConnectsStructuralMember> ConnectedBy { get; set; } // inverse

        public new static IfcStructuralMember FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralMember>(json);
        }
    }
}