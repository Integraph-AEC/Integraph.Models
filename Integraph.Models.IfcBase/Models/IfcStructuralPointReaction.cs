using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralpointreaction.htm" />
	/// </summary>
	public class IfcStructuralPointReaction : IfcStructuralReaction
    {
	    /// <summary>
	    ///     Construct a IfcStructuralPointReaction with all required attributes.
	    /// </summary>
	    public IfcStructuralPointReaction(IfcGloballyUniqueId globalId, IfcStructuralLoad appliedLoad,
            IfcGlobalOrLocalEnum globalOrLocal) : base(globalId, appliedLoad, globalOrLocal)
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralPointReaction with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralPointReaction(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal)
            : base(globalId, ownerHistory, name, description, objectType, objectPlacement, representation, appliedLoad,
                globalOrLocal)
        {
        }

        public new static IfcStructuralPointReaction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralPointReaction>(json);
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
	            AppliedLoad != null ? AppliedLoad.ToStepValue() : "$",
	            GlobalOrLocal.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}