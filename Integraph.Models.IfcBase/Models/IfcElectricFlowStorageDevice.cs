using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcelectricflowstoragedevice.htm" />
	/// </summary>
	public class IfcElectricFlowStorageDevice : IfcFlowStorageDevice
    {
	    /// <summary>
	    ///     Construct a IfcElectricFlowStorageDevice with all required attributes.
	    /// </summary>
	    public IfcElectricFlowStorageDevice(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcElectricFlowStorageDevice with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcElectricFlowStorageDevice(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag,
            IfcElectricFlowStorageDeviceTypeEnum predefinedType) : base(globalId, ownerHistory, name, description,
            objectType, objectPlacement, representation, tag)
        {
            PredefinedType = predefinedType;
        }

        public IfcElectricFlowStorageDeviceTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcElectricFlowStorageDevice FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcElectricFlowStorageDevice>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ObjectType != null ? ObjectType.ToStepValue() : "$",
	            ObjectPlacement != null ? ObjectPlacement.ToStepValue() : "$",
	            Representation != null ? Representation.ToStepValue() : "$",
	            Tag != null ? Tag.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}