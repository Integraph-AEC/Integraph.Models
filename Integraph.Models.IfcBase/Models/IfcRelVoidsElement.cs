using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelvoidselement.htm" />
	/// </summary>
	public class IfcRelVoidsElement : IfcRelDecomposes
    {
	    /// <summary>
	    ///     Construct a IfcRelVoidsElement with all required attributes.
	    /// </summary>
	    public IfcRelVoidsElement(IfcGloballyUniqueId globalId, IfcElement relatingBuildingElement,
            IfcFeatureElementSubtraction relatedOpeningElement) : base(globalId)
        {
            RelatingBuildingElement = relatingBuildingElement;
            RelatedOpeningElement = relatedOpeningElement;
        }

	    /// <summary>
	    ///     Construct a IfcRelVoidsElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelVoidsElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcElement relatingBuildingElement, IfcFeatureElementSubtraction relatedOpeningElement)
            : base(globalId, ownerHistory, name, description)
        {
            RelatingBuildingElement = relatingBuildingElement;
            RelatedOpeningElement = relatedOpeningElement;
        }

        public IfcElement RelatingBuildingElement { get; set; }
        public IfcFeatureElementSubtraction RelatedOpeningElement { get; set; }

        public new static IfcRelVoidsElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelVoidsElement>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingBuildingElement != null ? RelatingBuildingElement.ToStepValue() : "$",
                RelatedOpeningElement != null ? RelatedOpeningElement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}