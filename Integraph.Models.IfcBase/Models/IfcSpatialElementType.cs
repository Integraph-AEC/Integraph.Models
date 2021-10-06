using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcspatialelementtype.htm" />
	/// </summary>
	public abstract class IfcSpatialElementType : IfcTypeProduct
    {
	    /// <summary>
	    ///     Construct a IfcSpatialElementType with all required attributes.
	    /// </summary>
	    public IfcSpatialElementType(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcSpatialElementType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSpatialElementType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType) : base(globalId,
            ownerHistory, name, description, applicableOccurrence, hasPropertySets, representationMaps, tag)
        {
            ElementType = elementType;
        }

        public IfcLabel ElementType { get; set; } // optional

        public new static IfcSpatialElementType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSpatialElementType>(json);
        }
    }
}