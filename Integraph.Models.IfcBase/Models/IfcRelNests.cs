using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelnests.htm" />
	/// </summary>
	public class IfcRelNests : IfcRelDecomposes
    {
	    /// <summary>
	    ///     Construct a IfcRelNests with all required attributes.
	    /// </summary>
	    public IfcRelNests(IfcGloballyUniqueId globalId, IfcObjectDefinition relatingObject,
            List<IfcObjectDefinition> relatedObjects) : base(globalId)
        {
            RelatingObject = relatingObject;
            RelatedObjects = relatedObjects;
        }

	    /// <summary>
	    ///     Construct a IfcRelNests with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelNests(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcObjectDefinition relatingObject, List<IfcObjectDefinition> relatedObjects) : base(
            globalId, ownerHistory, name, description)
        {
            RelatingObject = relatingObject;
            RelatedObjects = relatedObjects;
        }

        public IfcObjectDefinition RelatingObject { get; set; }
        public List<IfcObjectDefinition> RelatedObjects { get; set; }

        public new static IfcRelNests FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelNests>(json);
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