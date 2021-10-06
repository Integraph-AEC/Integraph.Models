using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcaudiovisualappliance.htm" />
	/// </summary>
	public class IfcAudioVisualAppliance : IfcFlowTerminal
    {
	    /// <summary>
	    ///     Construct a IfcAudioVisualAppliance with all required attributes.
	    /// </summary>
	    public IfcAudioVisualAppliance(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcAudioVisualAppliance with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcAudioVisualAppliance(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcAudioVisualApplianceTypeEnum predefinedType)
            : base(globalId, ownerHistory, name, description, objectType, objectPlacement, representation, tag)
        {
            PredefinedType = predefinedType;
        }

        public IfcAudioVisualApplianceTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcAudioVisualAppliance FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAudioVisualAppliance>(json);
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