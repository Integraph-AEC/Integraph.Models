using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralconnection.htm" />
	/// </summary>
	public abstract class IfcStructuralConnection : IfcStructuralItem
    {
	    /// <summary>
	    ///     Construct a IfcStructuralConnection with all required attributes.
	    /// </summary>
	    public IfcStructuralConnection(IfcGloballyUniqueId globalId) : base(globalId)
        {
            ConnectsStructuralMembers = new List<IfcRelConnectsStructuralMember>();
        }

	    /// <summary>
	    ///     Construct a IfcStructuralConnection with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralConnection(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcBoundaryCondition appliedCondition) : base(globalId,
            ownerHistory, name, description, objectType, objectPlacement, representation)
        {
            ConnectsStructuralMembers = new List<IfcRelConnectsStructuralMember>();

            AppliedCondition = appliedCondition;
        }

        public IfcBoundaryCondition AppliedCondition { get; set; } // optional
        public List<IfcRelConnectsStructuralMember> ConnectsStructuralMembers { get; set; } // inverse

        public new static IfcStructuralConnection FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralConnection>(json);
        }
    }
}