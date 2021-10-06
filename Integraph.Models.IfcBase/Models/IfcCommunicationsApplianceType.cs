using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccommunicationsappliancetype.htm" />
	/// </summary>
	public class IfcCommunicationsApplianceType : IfcFlowTerminalType
    {
	    /// <summary>
	    ///     Construct a IfcCommunicationsApplianceType with all required attributes.
	    /// </summary>
	    public IfcCommunicationsApplianceType(IfcGloballyUniqueId globalId,
            IfcCommunicationsApplianceTypeEnum predefinedType) : base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcCommunicationsApplianceType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCommunicationsApplianceType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType,
            IfcCommunicationsApplianceTypeEnum predefinedType) : base(globalId, ownerHistory, name, description,
            applicableOccurrence, hasPropertySets, representationMaps, tag, elementType)
        {
            PredefinedType = predefinedType;
        }

        public IfcCommunicationsApplianceTypeEnum? PredefinedType { get; set; }

        public new static IfcCommunicationsApplianceType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCommunicationsApplianceType>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                ApplicableOccurrence != null ? ApplicableOccurrence.ToStepValue() : "$",
                HasPropertySets != null ? HasPropertySets.ToStepValue() : "$",
                RepresentationMaps != null ? RepresentationMaps.ToStepValue() : "$",
                Tag != null ? Tag.ToStepValue() : "$",
                ElementType != null ? ElementType.ToStepValue() : "$",
                PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}