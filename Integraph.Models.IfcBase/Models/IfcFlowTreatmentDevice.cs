using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcflowtreatmentdevice.htm" />
	/// </summary>
	public class IfcFlowTreatmentDevice : IfcDistributionFlowElement
    {
	    /// <summary>
	    ///     Construct a IfcFlowTreatmentDevice with all required attributes.
	    /// </summary>
	    public IfcFlowTreatmentDevice(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcFlowTreatmentDevice with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFlowTreatmentDevice(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag) : base(globalId, ownerHistory, name,
            description, objectType, objectPlacement, representation, tag)
        {
        }

        public new static IfcFlowTreatmentDevice FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFlowTreatmentDevice>(json);
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
	            Tag != null ? Tag.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}