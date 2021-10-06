using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcflowcontrollertype.htm" />
	/// </summary>
	public abstract class IfcFlowControllerType : IfcDistributionFlowElementType
    {
	    /// <summary>
	    ///     Construct a IfcFlowControllerType with all required attributes.
	    /// </summary>
	    public IfcFlowControllerType(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcFlowControllerType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFlowControllerType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType) : base(globalId,
            ownerHistory, name, description, applicableOccurrence, hasPropertySets, representationMaps, tag,
            elementType)
        {
        }

        public new static IfcFlowControllerType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFlowControllerType>(json);
        }
    }
}