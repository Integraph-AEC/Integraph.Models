using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelconnectsporttoelement.htm" />
	/// </summary>
	public class IfcRelConnectsPortToElement : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelConnectsPortToElement with all required attributes.
	    /// </summary>
	    public IfcRelConnectsPortToElement(IfcGloballyUniqueId globalId, IfcPort relatingPort,
            IfcDistributionElement relatedElement) : base(globalId)
        {
            RelatingPort = relatingPort;
            RelatedElement = relatedElement;
        }

	    /// <summary>
	    ///     Construct a IfcRelConnectsPortToElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelConnectsPortToElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcPort relatingPort, IfcDistributionElement relatedElement) : base(globalId,
            ownerHistory, name, description)
        {
            RelatingPort = relatingPort;
            RelatedElement = relatedElement;
        }

        public IfcPort RelatingPort { get; set; }
        public IfcDistributionElement RelatedElement { get; set; }

        public new static IfcRelConnectsPortToElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelConnectsPortToElement>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingPort != null ? RelatingPort.ToStepValue() : "$",
                RelatedElement != null ? RelatedElement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}