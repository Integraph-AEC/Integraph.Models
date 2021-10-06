using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbuildingelementtype.htm" />
	/// </summary>
	public abstract class IfcBuildingElementType : IfcElementType
    {
	    /// <summary>
	    ///     Construct a IfcBuildingElementType with all required attributes.
	    /// </summary>
	    public IfcBuildingElementType(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcBuildingElementType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBuildingElementType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType) : base(globalId,
            ownerHistory, name, description, applicableOccurrence, hasPropertySets, representationMaps, tag,
            elementType)
        {
        }

        public new static IfcBuildingElementType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBuildingElementType>(json);
        }
    }
}