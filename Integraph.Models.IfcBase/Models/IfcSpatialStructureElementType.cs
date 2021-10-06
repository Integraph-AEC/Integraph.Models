using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcspatialstructureelementtype.htm" />
	/// </summary>
	public abstract class IfcSpatialStructureElementType : IfcSpatialElementType
    {
	    /// <summary>
	    ///     Construct a IfcSpatialStructureElementType with all required attributes.
	    /// </summary>
	    public IfcSpatialStructureElementType(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcSpatialStructureElementType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSpatialStructureElementType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType) : base(globalId,
            ownerHistory, name, description, applicableOccurrence, hasPropertySets, representationMaps, tag,
            elementType)
        {
        }

        public new static IfcSpatialStructureElementType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSpatialStructureElementType>(json);
        }
    }
}