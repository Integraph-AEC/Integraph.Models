using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelconnectswithrealizingelements.htm" />
	/// </summary>
	public class IfcRelConnectsWithRealizingElements : IfcRelConnectsElements
    {
	    /// <summary>
	    ///     Construct a IfcRelConnectsWithRealizingElements with all required attributes.
	    /// </summary>
	    public IfcRelConnectsWithRealizingElements(IfcGloballyUniqueId globalId, IfcElement relatingElement,
            IfcElement relatedElement, List<IfcElement> realizingElements) : base(globalId, relatingElement,
            relatedElement)
        {
            RealizingElements = realizingElements;
        }

	    /// <summary>
	    ///     Construct a IfcRelConnectsWithRealizingElements with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelConnectsWithRealizingElements(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory,
            IfcLabel name, IfcText description, IfcConnectionGeometry connectionGeometry, IfcElement relatingElement,
            IfcElement relatedElement, List<IfcElement> realizingElements, IfcLabel connectionType) : base(globalId,
            ownerHistory, name, description, connectionGeometry, relatingElement, relatedElement)
        {
            RealizingElements = realizingElements;
            ConnectionType = connectionType;
        }

        public List<IfcElement> RealizingElements { get; set; }
        public IfcLabel ConnectionType { get; set; } // optional

        public new static IfcRelConnectsWithRealizingElements FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelConnectsWithRealizingElements>(json);
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
                RealizingElements != null ? RealizingElements.ToStepValue() : "$",
                ConnectionType != null ? ConnectionType.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}