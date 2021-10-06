using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcflowterminaltype.htm" />
	/// </summary>
	public abstract class IfcFlowTerminalType : IfcDistributionFlowElementType
    {
	    /// <summary>
	    ///     Construct a IfcFlowTerminalType with all required attributes.
	    /// </summary>
	    public IfcFlowTerminalType(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcFlowTerminalType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFlowTerminalType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType) : base(globalId,
            ownerHistory, name, description, applicableOccurrence, hasPropertySets, representationMaps, tag,
            elementType)
        {
        }

        public new static IfcFlowTerminalType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFlowTerminalType>(json);
        }
    }
}