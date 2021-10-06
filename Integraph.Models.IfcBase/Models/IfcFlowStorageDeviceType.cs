using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcflowstoragedevicetype.htm" />
	/// </summary>
	public abstract class IfcFlowStorageDeviceType : IfcDistributionFlowElementType
    {
	    /// <summary>
	    ///     Construct a IfcFlowStorageDeviceType with all required attributes.
	    /// </summary>
	    public IfcFlowStorageDeviceType(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcFlowStorageDeviceType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFlowStorageDeviceType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType) : base(globalId,
            ownerHistory, name, description, applicableOccurrence, hasPropertySets, representationMaps, tag,
            elementType)
        {
        }

        public new static IfcFlowStorageDeviceType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFlowStorageDeviceType>(json);
        }
    }
}