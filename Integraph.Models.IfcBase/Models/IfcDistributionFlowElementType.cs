using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdistributionflowelementtype.htm" />
	/// </summary>
	public abstract class IfcDistributionFlowElementType : IfcDistributionElementType
    {
	    /// <summary>
	    ///     Construct a IfcDistributionFlowElementType with all required attributes.
	    /// </summary>
	    public IfcDistributionFlowElementType(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcDistributionFlowElementType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDistributionFlowElementType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType) : base(globalId,
            ownerHistory, name, description, applicableOccurrence, hasPropertySets, representationMaps, tag,
            elementType)
        {
        }

        public new static IfcDistributionFlowElementType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDistributionFlowElementType>(json);
        }
    }
}