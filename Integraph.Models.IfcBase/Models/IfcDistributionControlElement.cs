using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdistributioncontrolelement.htm" />
	/// </summary>
	public class IfcDistributionControlElement : IfcDistributionElement
    {
	    /// <summary>
	    ///     Construct a IfcDistributionControlElement with all required attributes.
	    /// </summary>
	    public IfcDistributionControlElement(IfcGloballyUniqueId globalId) : base(globalId)
        {
            AssignedToFlowElement = new List<IfcRelFlowControlElements>();
        }

	    /// <summary>
	    ///     Construct a IfcDistributionControlElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDistributionControlElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag) : base(globalId, ownerHistory, name,
            description, objectType, objectPlacement, representation, tag)
        {
            AssignedToFlowElement = new List<IfcRelFlowControlElements>();
        }

        public List<IfcRelFlowControlElements> AssignedToFlowElement { get; set; } // inverse

        public new static IfcDistributionControlElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDistributionControlElement>(json);
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