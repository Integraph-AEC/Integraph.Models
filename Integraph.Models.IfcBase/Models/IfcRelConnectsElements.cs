using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelconnectselements.htm" />
	/// </summary>
	public class IfcRelConnectsElements : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelConnectsElements with all required attributes.
	    /// </summary>
	    public IfcRelConnectsElements(IfcGloballyUniqueId globalId, IfcElement relatingElement,
            IfcElement relatedElement) : base(globalId)
        {
            RelatingElement = relatingElement;
            RelatedElement = relatedElement;
        }

	    /// <summary>
	    ///     Construct a IfcRelConnectsElements with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelConnectsElements(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcConnectionGeometry connectionGeometry, IfcElement relatingElement,
            IfcElement relatedElement) : base(globalId, ownerHistory, name, description)
        {
            ConnectionGeometry = connectionGeometry;
            RelatingElement = relatingElement;
            RelatedElement = relatedElement;
        }

        public IfcConnectionGeometry ConnectionGeometry { get; set; } // optional
        public IfcElement RelatingElement { get; set; }
        public IfcElement RelatedElement { get; set; }

        public new static IfcRelConnectsElements FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelConnectsElements>(json);
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
                RelatedElement != null ? RelatedElement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}