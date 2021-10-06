using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassignstoactor.htm" />
	/// </summary>
	public class IfcRelAssignsToActor : IfcRelAssigns
    {
	    /// <summary>
	    ///     Construct a IfcRelAssignsToActor with all required attributes.
	    /// </summary>
	    public IfcRelAssignsToActor(IfcGloballyUniqueId globalId, List<IfcObjectDefinition> relatedObjects,
            IfcActor relatingActor) : base(globalId, relatedObjects)
        {
            RelatingActor = relatingActor;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssignsToActor with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssignsToActor(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcObjectDefinition> relatedObjects, IfcObjectTypeEnum relatedObjectsType,
            IfcActor relatingActor, IfcActorRole actingRole) : base(globalId, ownerHistory, name, description,
            relatedObjects, relatedObjectsType)
        {
            RelatingActor = relatingActor;
            ActingRole = actingRole;
        }

        public IfcActor RelatingActor { get; set; }
        public IfcActorRole ActingRole { get; set; } // optional

        public new static IfcRelAssignsToActor FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssignsToActor>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatedObjects != null ? RelatedObjects.ToStepValue() : "$",
                RelatedObjectsType.ToStepValue(),
                RelatingActor != null ? RelatingActor.ToStepValue() : "$",
                ActingRole != null ? ActingRole.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}