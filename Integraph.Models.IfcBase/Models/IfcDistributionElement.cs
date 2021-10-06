using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdistributionelement.htm" />
	/// </summary>
	public class IfcDistributionElement : IfcElement
    {
	    /// <summary>
	    ///     Construct a IfcDistributionElement with all required attributes.
	    /// </summary>
	    public IfcDistributionElement(IfcGloballyUniqueId globalId) : base(globalId)
        {
            HasPorts = new List<IfcRelConnectsPortToElement>();
        }

	    /// <summary>
	    ///     Construct a IfcDistributionElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDistributionElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag) : base(globalId, ownerHistory, name,
            description, objectType, objectPlacement, representation, tag)
        {
            HasPorts = new List<IfcRelConnectsPortToElement>();
        }

        public List<IfcRelConnectsPortToElement> HasPorts { get; set; } // inverse

        public new static IfcDistributionElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDistributionElement>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ObjectType != null ? ObjectType.ToStepValue() : "$",
	            ObjectPlacement != null ? ObjectPlacement.ToStepValue() : "$",
	            Representation != null ? Representation.ToStepValue() : "$",
	            Tag != null ? Tag.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}