using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelprojectselement.htm" />
	/// </summary>
	public class IfcRelProjectsElement : IfcRelDecomposes
    {
	    /// <summary>
	    ///     Construct a IfcRelProjectsElement with all required attributes.
	    /// </summary>
	    public IfcRelProjectsElement(IfcGloballyUniqueId globalId, IfcElement relatingElement,
            IfcFeatureElementAddition relatedFeatureElement) : base(globalId)
        {
            RelatingElement = relatingElement;
            RelatedFeatureElement = relatedFeatureElement;
        }

	    /// <summary>
	    ///     Construct a IfcRelProjectsElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelProjectsElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcElement relatingElement, IfcFeatureElementAddition relatedFeatureElement) : base(
            globalId, ownerHistory, name, description)
        {
            RelatingElement = relatingElement;
            RelatedFeatureElement = relatedFeatureElement;
        }

        public IfcElement RelatingElement { get; set; }
        public IfcFeatureElementAddition RelatedFeatureElement { get; set; }

        public new static IfcRelProjectsElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelProjectsElement>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingElement != null ? RelatingElement.ToStepValue() : "$",
                RelatedFeatureElement != null ? RelatedFeatureElement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}