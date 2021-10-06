using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreinforcingelementtype.htm" />
	/// </summary>
	public abstract class IfcReinforcingElementType : IfcElementComponentType
    {
	    /// <summary>
	    ///     Construct a IfcReinforcingElementType with all required attributes.
	    /// </summary>
	    public IfcReinforcingElementType(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcReinforcingElementType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcReinforcingElementType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType) : base(globalId,
            ownerHistory, name, description, applicableOccurrence, hasPropertySets, representationMaps, tag,
            elementType)
        {
        }

        public new static IfcReinforcingElementType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcReinforcingElementType>(json);
        }
    }
}