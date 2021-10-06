using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcflowtreatmentdevicetype.htm" />
	/// </summary>
	public abstract class IfcFlowTreatmentDeviceType : IfcDistributionFlowElementType
    {
	    /// <summary>
	    ///     Construct a IfcFlowTreatmentDeviceType with all required attributes.
	    /// </summary>
	    public IfcFlowTreatmentDeviceType(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcFlowTreatmentDeviceType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFlowTreatmentDeviceType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType) : base(globalId,
            ownerHistory, name, description, applicableOccurrence, hasPropertySets, representationMaps, tag,
            elementType)
        {
        }

        public new static IfcFlowTreatmentDeviceType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFlowTreatmentDeviceType>(json);
        }
    }
}