using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcresourceapprovalrelationship.htm" />
	/// </summary>
	public class IfcResourceApprovalRelationship : IfcResourceLevelRelationship
    {
	    /// <summary>
	    ///     Construct a IfcResourceApprovalRelationship with all required attributes.
	    /// </summary>
	    public IfcResourceApprovalRelationship(List<IfcResourceObjectSelect> relatedResourceObjects,
            IfcApproval relatingApproval)
        {
            RelatedResourceObjects = relatedResourceObjects;
            RelatingApproval = relatingApproval;
        }

	    /// <summary>
	    ///     Construct a IfcResourceApprovalRelationship with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcResourceApprovalRelationship(IfcLabel name, IfcText description,
            List<IfcResourceObjectSelect> relatedResourceObjects, IfcApproval relatingApproval) : base(name,
            description)
        {
            RelatedResourceObjects = relatedResourceObjects;
            RelatingApproval = relatingApproval;
        }

        public List<IfcResourceObjectSelect> RelatedResourceObjects { get; set; }
        public IfcApproval RelatingApproval { get; set; }

        public new static IfcResourceApprovalRelationship FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcResourceApprovalRelationship>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatedResourceObjects != null ? RelatedResourceObjects.ToStepValue() : "$",
                RelatingApproval != null ? RelatingApproval.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}