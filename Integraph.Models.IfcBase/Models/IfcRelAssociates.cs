using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassociates.htm" />
	/// </summary>
	public abstract class IfcRelAssociates : IfcRelationship
    {
	    /// <summary>
	    ///     Construct a IfcRelAssociates with all required attributes.
	    /// </summary>
	    public IfcRelAssociates(IfcGloballyUniqueId globalId, List<IfcDefinitionSelect> relatedObjects) : base(globalId)
        {
            RelatedObjects = relatedObjects;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssociates with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssociates(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcDefinitionSelect> relatedObjects) : base(globalId, ownerHistory, name,
            description)
        {
            RelatedObjects = relatedObjects;
        }

        public List<IfcDefinitionSelect> RelatedObjects { get; set; }

        public new static IfcRelAssociates FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssociates>(json);
        }
    }
}