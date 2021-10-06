using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassignstoresource.htm" />
	/// </summary>
	public class IfcRelAssignsToResource : IfcRelAssigns
    {
	    /// <summary>
	    ///     Construct a IfcRelAssignsToResource with all required attributes.
	    /// </summary>
	    public IfcRelAssignsToResource(IfcGloballyUniqueId globalId, List<IfcObjectDefinition> relatedObjects,
            IfcResourceSelect relatingResource) : base(globalId, relatedObjects)
        {
            RelatingResource = relatingResource;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssignsToResource with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssignsToResource(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcObjectDefinition> relatedObjects, IfcObjectTypeEnum relatedObjectsType,
            IfcResourceSelect relatingResource) : base(globalId, ownerHistory, name, description, relatedObjects,
            relatedObjectsType)
        {
            RelatingResource = relatingResource;
        }

        public IfcResourceSelect RelatingResource { get; set; }

        public new static IfcRelAssignsToResource FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssignsToResource>(json);
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
                RelatingResource != null ? RelatingResource.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}