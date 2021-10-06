using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassignstogroup.htm" />
	/// </summary>
	public class IfcRelAssignsToGroup : IfcRelAssigns
    {
	    /// <summary>
	    ///     Construct a IfcRelAssignsToGroup with all required attributes.
	    /// </summary>
	    public IfcRelAssignsToGroup(IfcGloballyUniqueId globalId, List<IfcObjectDefinition> relatedObjects,
            IfcGroup relatingGroup) : base(globalId, relatedObjects)
        {
            RelatingGroup = relatingGroup;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssignsToGroup with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssignsToGroup(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcObjectDefinition> relatedObjects, IfcObjectTypeEnum relatedObjectsType,
            IfcGroup relatingGroup) : base(globalId, ownerHistory, name, description, relatedObjects,
            relatedObjectsType)
        {
            RelatingGroup = relatingGroup;
        }

        public IfcGroup RelatingGroup { get; set; }

        public new static IfcRelAssignsToGroup FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssignsToGroup>(json);
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
                RelatingGroup != null ? RelatingGroup.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}