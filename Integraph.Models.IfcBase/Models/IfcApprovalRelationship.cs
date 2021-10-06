using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcapprovalrelationship.htm" />
	/// </summary>
	public class IfcApprovalRelationship : IfcResourceLevelRelationship
    {
	    /// <summary>
	    ///     Construct a IfcApprovalRelationship with all required attributes.
	    /// </summary>
	    public IfcApprovalRelationship(IfcApproval relatingApproval, List<IfcApproval> relatedApprovals)
        {
            RelatingApproval = relatingApproval;
            RelatedApprovals = relatedApprovals;
        }

	    /// <summary>
	    ///     Construct a IfcApprovalRelationship with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcApprovalRelationship(IfcLabel name, IfcText description, IfcApproval relatingApproval,
            List<IfcApproval> relatedApprovals) : base(name, description)
        {
            RelatingApproval = relatingApproval;
            RelatedApprovals = relatedApprovals;
        }

        public IfcApproval RelatingApproval { get; set; }
        public List<IfcApproval> RelatedApprovals { get; set; }

        public new static IfcApprovalRelationship FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcApprovalRelationship>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            RelatingApproval != null ? RelatingApproval.ToStepValue() : "$",
	            RelatedApprovals != null ? RelatedApprovals.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}