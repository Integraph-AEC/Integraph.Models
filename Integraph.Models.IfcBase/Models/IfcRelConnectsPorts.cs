using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelconnectsports.htm" />
	/// </summary>
	public class IfcRelConnectsPorts : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelConnectsPorts with all required attributes.
	    /// </summary>
	    public IfcRelConnectsPorts(IfcGloballyUniqueId globalId, IfcPort relatingPort, IfcPort relatedPort) :
            base(globalId)
        {
            RelatingPort = relatingPort;
            RelatedPort = relatedPort;
        }

	    /// <summary>
	    ///     Construct a IfcRelConnectsPorts with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelConnectsPorts(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcPort relatingPort, IfcPort relatedPort, IfcElement realizingElement) : base(
            globalId, ownerHistory, name, description)
        {
            RelatingPort = relatingPort;
            RelatedPort = relatedPort;
            RealizingElement = realizingElement;
        }

        public IfcPort RelatingPort { get; set; }
        public IfcPort RelatedPort { get; set; }
        public IfcElement RealizingElement { get; set; } // optional

        public new static IfcRelConnectsPorts FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelConnectsPorts>(json);
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
                RelatedPort != null ? RelatedPort.ToStepValue() : "$",
                RealizingElement != null ? RealizingElement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}