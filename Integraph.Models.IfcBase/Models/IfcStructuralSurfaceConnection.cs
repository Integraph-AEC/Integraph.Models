using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralsurfaceconnection.htm" />
	/// </summary>
	public class IfcStructuralSurfaceConnection : IfcStructuralConnection
    {
	    /// <summary>
	    ///     Construct a IfcStructuralSurfaceConnection with all required attributes.
	    /// </summary>
	    public IfcStructuralSurfaceConnection(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralSurfaceConnection with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralSurfaceConnection(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcBoundaryCondition appliedCondition) : base(globalId,
            ownerHistory, name, description, objectType, objectPlacement, representation, appliedCondition)
        {
        }

        public new static IfcStructuralSurfaceConnection FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralSurfaceConnection>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ObjectType != null ? ObjectType.ToStepValue() : "$",
	            ObjectPlacement != null ? ObjectPlacement.ToStepValue() : "$",
	            Representation != null ? Representation.ToStepValue() : "$",
	            AppliedCondition != null ? AppliedCondition.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}