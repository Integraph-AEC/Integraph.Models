using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdistributionflowelement.htm" />
	/// </summary>
	public class IfcDistributionFlowElement : IfcDistributionElement
    {
	    /// <summary>
	    ///     Construct a IfcDistributionFlowElement with all required attributes.
	    /// </summary>
	    public IfcDistributionFlowElement(IfcGloballyUniqueId globalId) : base(globalId)
        {
            HasControlElements = new List<IfcRelFlowControlElements>();
        }

	    /// <summary>
	    ///     Construct a IfcDistributionFlowElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDistributionFlowElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag) : base(globalId, ownerHistory, name,
            description, objectType, objectPlacement, representation, tag)
        {
            HasControlElements = new List<IfcRelFlowControlElements>();
        }

        public List<IfcRelFlowControlElements> HasControlElements { get; set; } // inverse

        public new static IfcDistributionFlowElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDistributionFlowElement>(json);
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