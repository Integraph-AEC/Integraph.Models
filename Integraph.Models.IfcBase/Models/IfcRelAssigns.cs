using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassigns.htm" />
	/// </summary>
	public abstract class IfcRelAssigns : IfcRelationship
    {
	    /// <summary>
	    ///     Construct a IfcRelAssigns with all required attributes.
	    /// </summary>
	    public IfcRelAssigns(IfcGloballyUniqueId globalId, List<IfcObjectDefinition> relatedObjects) : base(globalId)
        {
            RelatedObjects = relatedObjects;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssigns with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssigns(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcObjectDefinition> relatedObjects, IfcObjectTypeEnum relatedObjectsType) : base(
            globalId, ownerHistory, name, description)
        {
            RelatedObjects = relatedObjects;
            RelatedObjectsType = relatedObjectsType;
        }

        public List<IfcObjectDefinition> RelatedObjects { get; set; }
        public IfcObjectTypeEnum? RelatedObjectsType { get; set; } // optional

        public new static IfcRelAssigns FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssigns>(json);
        }
    }
}