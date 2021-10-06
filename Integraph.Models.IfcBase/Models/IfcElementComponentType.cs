using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcelementcomponenttype.htm" />
	/// </summary>
	public abstract class IfcElementComponentType : IfcElementType
    {
	    /// <summary>
	    ///     Construct a IfcElementComponentType with all required attributes.
	    /// </summary>
	    public IfcElementComponentType(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcElementComponentType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcElementComponentType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType) : base(globalId,
            ownerHistory, name, description, applicableOccurrence, hasPropertySets, representationMaps, tag,
            elementType)
        {
        }

        public new static IfcElementComponentType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcElementComponentType>(json);
        }
    }
}