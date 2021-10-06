using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelfillselement.htm" />
	/// </summary>
	public class IfcRelFillsElement : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelFillsElement with all required attributes.
	    /// </summary>
	    public IfcRelFillsElement(IfcGloballyUniqueId globalId, IfcOpeningElement relatingOpeningElement,
            IfcElement relatedBuildingElement) : base(globalId)
        {
            RelatingOpeningElement = relatingOpeningElement;
            RelatedBuildingElement = relatedBuildingElement;
        }

	    /// <summary>
	    ///     Construct a IfcRelFillsElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelFillsElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcOpeningElement relatingOpeningElement, IfcElement relatedBuildingElement) : base(
            globalId, ownerHistory, name, description)
        {
            RelatingOpeningElement = relatingOpeningElement;
            RelatedBuildingElement = relatedBuildingElement;
        }

        public IfcOpeningElement RelatingOpeningElement { get; set; }
        public IfcElement RelatedBuildingElement { get; set; }

        public new static IfcRelFillsElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelFillsElement>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingOpeningElement != null ? RelatingOpeningElement.ToStepValue() : "$",
                RelatedBuildingElement != null ? RelatedBuildingElement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}