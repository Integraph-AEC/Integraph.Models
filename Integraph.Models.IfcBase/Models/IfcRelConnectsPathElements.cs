using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelconnectspathelements.htm" />
	/// </summary>
	public class IfcRelConnectsPathElements : IfcRelConnectsElements
    {
	    /// <summary>
	    ///     Construct a IfcRelConnectsPathElements with all required attributes.
	    /// </summary>
	    public IfcRelConnectsPathElements(IfcGloballyUniqueId globalId, IfcElement relatingElement,
            IfcElement relatedElement, List<IfcInteger> relatingPriorities, List<IfcInteger> relatedPriorities,
            IfcConnectionTypeEnum relatedConnectionType, IfcConnectionTypeEnum relatingConnectionType) : base(globalId,
            relatingElement, relatedElement)
        {
            RelatingPriorities = relatingPriorities;
            RelatedPriorities = relatedPriorities;
            RelatedConnectionType = relatedConnectionType;
            RelatingConnectionType = relatingConnectionType;
        }

	    /// <summary>
	    ///     Construct a IfcRelConnectsPathElements with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelConnectsPathElements(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcConnectionGeometry connectionGeometry, IfcElement relatingElement,
            IfcElement relatedElement, List<IfcInteger> relatingPriorities, List<IfcInteger> relatedPriorities,
            IfcConnectionTypeEnum relatedConnectionType, IfcConnectionTypeEnum relatingConnectionType) : base(globalId,
            ownerHistory, name, description, connectionGeometry, relatingElement, relatedElement)
        {
            RelatingPriorities = relatingPriorities;
            RelatedPriorities = relatedPriorities;
            RelatedConnectionType = relatedConnectionType;
            RelatingConnectionType = relatingConnectionType;
        }

        public List<IfcInteger> RelatingPriorities { get; set; }
        public List<IfcInteger> RelatedPriorities { get; set; }
        public IfcConnectionTypeEnum? RelatedConnectionType { get; set; }
        public IfcConnectionTypeEnum? RelatingConnectionType { get; set; }

        public new static IfcRelConnectsPathElements FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelConnectsPathElements>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                ConnectionGeometry != null ? ConnectionGeometry.ToStepValue() : "$",
                RelatingElement != null ? RelatingElement.ToStepValue() : "$",
                RelatedElement != null ? RelatedElement.ToStepValue() : "$",
                RelatingPriorities != null ? RelatingPriorities.ToStepValue() : "$",
                RelatedPriorities != null ? RelatedPriorities.ToStepValue() : "$",
                RelatedConnectionType.ToStepValue(),
                RelatingConnectionType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}