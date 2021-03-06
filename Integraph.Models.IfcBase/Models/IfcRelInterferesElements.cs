using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelinterfereselements.htm" />
	/// </summary>
	public class IfcRelInterferesElements : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelInterferesElements with all required attributes.
	    /// </summary>
	    public IfcRelInterferesElements(IfcGloballyUniqueId globalId, IfcElement relatingElement,
            IfcElement relatedElement, bool? impliedOrder) : base(globalId)
        {
            RelatingElement = relatingElement;
            RelatedElement = relatedElement;
            ImpliedOrder = impliedOrder;
        }

	    /// <summary>
	    ///     Construct a IfcRelInterferesElements with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelInterferesElements(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcElement relatingElement, IfcElement relatedElement,
            IfcConnectionGeometry interferenceGeometry, IfcIdentifier interferenceType, bool? impliedOrder) : base(
            globalId, ownerHistory, name, description)
        {
            RelatingElement = relatingElement;
            RelatedElement = relatedElement;
            InterferenceGeometry = interferenceGeometry;
            InterferenceType = interferenceType;
            ImpliedOrder = impliedOrder;
        }

        public IfcElement RelatingElement { get; set; }
        public IfcElement RelatedElement { get; set; }
        public IfcConnectionGeometry InterferenceGeometry { get; set; } // optional
        public IfcIdentifier InterferenceType { get; set; } // optional
        public bool? ImpliedOrder { get; set; }

        public new static IfcRelInterferesElements FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelInterferesElements>(json);
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
                RelatedElement != null ? RelatedElement.ToStepValue() : "$",
                InterferenceGeometry != null ? InterferenceGeometry.ToStepValue() : "$",
                InterferenceType != null ? InterferenceType.ToStepValue() : "$",
                ImpliedOrder != null ? ImpliedOrder.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}