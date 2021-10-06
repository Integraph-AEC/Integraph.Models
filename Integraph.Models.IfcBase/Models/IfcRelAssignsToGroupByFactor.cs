using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassignstogroupbyfactor.htm" />
	/// </summary>
	public class IfcRelAssignsToGroupByFactor : IfcRelAssignsToGroup
    {
	    /// <summary>
	    ///     Construct a IfcRelAssignsToGroupByFactor with all required attributes.
	    /// </summary>
	    public IfcRelAssignsToGroupByFactor(IfcGloballyUniqueId globalId, List<IfcObjectDefinition> relatedObjects,
            IfcGroup relatingGroup, IfcRatioMeasure factor) : base(globalId, relatedObjects, relatingGroup)
        {
            Factor = factor;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssignsToGroupByFactor with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssignsToGroupByFactor(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcObjectDefinition> relatedObjects, IfcObjectTypeEnum relatedObjectsType,
            IfcGroup relatingGroup, IfcRatioMeasure factor) : base(globalId, ownerHistory, name, description,
            relatedObjects, relatedObjectsType, relatingGroup)
        {
            Factor = factor;
        }

        public IfcRatioMeasure Factor { get; set; }

        public new static IfcRelAssignsToGroupByFactor FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssignsToGroupByFactor>(json);
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
                RelatingGroup != null ? RelatingGroup.ToStepValue() : "$",
                Factor != null ? Factor.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}