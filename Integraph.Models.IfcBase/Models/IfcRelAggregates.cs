using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelaggregates.htm" />
	/// </summary>
	public class IfcRelAggregates : IfcRelDecomposes
    {
	    /// <summary>
	    ///     Construct a IfcRelAggregates with all required attributes.
	    /// </summary>
	    public IfcRelAggregates(IfcGloballyUniqueId globalId, IfcObjectDefinition relatingObject,
            List<IfcObjectDefinition> relatedObjects) : base(globalId)
        {
            RelatingObject = relatingObject;
            RelatedObjects = relatedObjects;
        }

	    /// <summary>
	    ///     Construct a IfcRelAggregates with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAggregates(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcObjectDefinition relatingObject, List<IfcObjectDefinition> relatedObjects) : base(
            globalId, ownerHistory, name, description)
        {
            RelatingObject = relatingObject;
            RelatedObjects = relatedObjects;
        }

        public IfcObjectDefinition RelatingObject { get; set; }
        public List<IfcObjectDefinition> RelatedObjects { get; set; }

        public new static IfcRelAggregates FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAggregates>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingObject != null ? RelatingObject.ToStepValue() : "$",
                RelatedObjects != null ? RelatedObjects.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}