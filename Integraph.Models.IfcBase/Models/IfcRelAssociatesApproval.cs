using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassociatesapproval.htm" />
	/// </summary>
	public class IfcRelAssociatesApproval : IfcRelAssociates
    {
	    /// <summary>
	    ///     Construct a IfcRelAssociatesApproval with all required attributes.
	    /// </summary>
	    public IfcRelAssociatesApproval(IfcGloballyUniqueId globalId, List<IfcDefinitionSelect> relatedObjects,
            IfcApproval relatingApproval) : base(globalId, relatedObjects)
        {
            RelatingApproval = relatingApproval;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssociatesApproval with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssociatesApproval(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcDefinitionSelect> relatedObjects, IfcApproval relatingApproval) : base(
            globalId, ownerHistory, name, description, relatedObjects)
        {
            RelatingApproval = relatingApproval;
        }

        public IfcApproval RelatingApproval { get; set; }

        public new static IfcRelAssociatesApproval FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssociatesApproval>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatedObjects != null ? RelatedObjects.ToStepValue() : "$",
                RelatingApproval != null ? RelatingApproval.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}