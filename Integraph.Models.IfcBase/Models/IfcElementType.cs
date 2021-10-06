using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcelementtype.htm" />
	/// </summary>
	public abstract class IfcElementType : IfcTypeProduct
    {
	    /// <summary>
	    ///     Construct a IfcElementType with all required attributes.
	    /// </summary>
	    public IfcElementType(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcElementType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcElementType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType) : base(globalId,
            ownerHistory, name, description, applicableOccurrence, hasPropertySets, representationMaps, tag)
        {
            ElementType = elementType;
        }

        public IfcLabel ElementType { get; set; } // optional

        public new static IfcElementType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcElementType>(json);
        }
    }
}