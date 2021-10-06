using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelflowcontrolelements.htm" />
	/// </summary>
	public class IfcRelFlowControlElements : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelFlowControlElements with all required attributes.
	    /// </summary>
	    public IfcRelFlowControlElements(IfcGloballyUniqueId globalId,
            List<IfcDistributionControlElement> relatedControlElements,
            IfcDistributionFlowElement relatingFlowElement) : base(globalId)
        {
            RelatedControlElements = relatedControlElements;
            RelatingFlowElement = relatingFlowElement;
        }

	    /// <summary>
	    ///     Construct a IfcRelFlowControlElements with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelFlowControlElements(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcDistributionControlElement> relatedControlElements,
            IfcDistributionFlowElement relatingFlowElement) : base(globalId, ownerHistory, name, description)
        {
            RelatedControlElements = relatedControlElements;
            RelatingFlowElement = relatingFlowElement;
        }

        public List<IfcDistributionControlElement> RelatedControlElements { get; set; }
        public IfcDistributionFlowElement RelatingFlowElement { get; set; }

        public new static IfcRelFlowControlElements FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelFlowControlElements>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatedControlElements != null ? RelatedControlElements.ToStepValue() : "$",
                RelatingFlowElement != null ? RelatingFlowElement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}