using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcflowmovingdevicetype.htm" />
	/// </summary>
	public abstract class IfcFlowMovingDeviceType : IfcDistributionFlowElementType
    {
	    /// <summary>
	    ///     Construct a IfcFlowMovingDeviceType with all required attributes.
	    /// </summary>
	    public IfcFlowMovingDeviceType(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcFlowMovingDeviceType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFlowMovingDeviceType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType) : base(globalId,
            ownerHistory, name, description, applicableOccurrence, hasPropertySets, representationMaps, tag,
            elementType)
        {
        }

        public new static IfcFlowMovingDeviceType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFlowMovingDeviceType>(json);
        }
    }
}