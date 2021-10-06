using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcelectricflowstoragedevicetype.htm" />
	/// </summary>
	public class IfcElectricFlowStorageDeviceType : IfcFlowStorageDeviceType
    {
	    /// <summary>
	    ///     Construct a IfcElectricFlowStorageDeviceType with all required attributes.
	    /// </summary>
	    public IfcElectricFlowStorageDeviceType(IfcGloballyUniqueId globalId,
            IfcElectricFlowStorageDeviceTypeEnum predefinedType) : base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcElectricFlowStorageDeviceType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcElectricFlowStorageDeviceType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory,
            IfcLabel name, IfcText description, IfcIdentifier applicableOccurrence,
            List<IfcPropertySetDefinition> hasPropertySets, List<IfcRepresentationMap> representationMaps, IfcLabel tag,
            IfcLabel elementType, IfcElectricFlowStorageDeviceTypeEnum predefinedType) : base(globalId, ownerHistory,
            name, description, applicableOccurrence, hasPropertySets, representationMaps, tag, elementType)
        {
            PredefinedType = predefinedType;
        }

        public IfcElectricFlowStorageDeviceTypeEnum? PredefinedType { get; set; }

        public new static IfcElectricFlowStorageDeviceType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcElectricFlowStorageDeviceType>(json);
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