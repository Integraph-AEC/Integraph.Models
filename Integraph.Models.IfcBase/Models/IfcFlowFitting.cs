using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcflowfitting.htm" />
	/// </summary>
	public class IfcFlowFitting : IfcDistributionFlowElement
    {
	    /// <summary>
	    ///     Construct a IfcFlowFitting with all required attributes.
	    /// </summary>
	    public IfcFlowFitting(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcFlowFitting with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFlowFitting(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag) : base(globalId, ownerHistory, name,
            description, objectType, objectPlacement, representation, tag)
        {
        }

        public new static IfcFlowFitting FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFlowFitting>(json);
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