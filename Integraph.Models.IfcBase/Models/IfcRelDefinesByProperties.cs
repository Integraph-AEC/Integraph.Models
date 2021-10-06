using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreldefinesbyproperties.htm" />
	/// </summary>
	public class IfcRelDefinesByProperties : IfcRelDefines
    {
	    /// <summary>
	    ///     Construct a IfcRelDefinesByProperties with all required attributes.
	    /// </summary>
	    public IfcRelDefinesByProperties(IfcGloballyUniqueId globalId, List<IfcObjectDefinition> relatedObjects,
            IfcPropertySetDefinitionSelect relatingPropertyDefinition) : base(globalId)
        {
            RelatedObjects = relatedObjects;
            RelatingPropertyDefinition = relatingPropertyDefinition;
        }

	    /// <summary>
	    ///     Construct a IfcRelDefinesByProperties with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelDefinesByProperties(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcObjectDefinition> relatedObjects,
            IfcPropertySetDefinitionSelect relatingPropertyDefinition) : base(globalId, ownerHistory, name, description)
        {
            RelatedObjects = relatedObjects;
            RelatingPropertyDefinition = relatingPropertyDefinition;
        }

        public List<IfcObjectDefinition> RelatedObjects { get; set; }
        public IfcPropertySetDefinitionSelect RelatingPropertyDefinition { get; set; }

        public new static IfcRelDefinesByProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelDefinesByProperties>(json);
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
                RelatingPropertyDefinition != null ? RelatingPropertyDefinition.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}