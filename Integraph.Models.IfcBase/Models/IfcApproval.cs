using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcapproval.htm" />
	/// </summary>
	public class IfcApproval : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcApproval with all required attributes.
	    /// </summary>
	    public IfcApproval()
        {
            HasExternalReferences = new List<IfcExternalReferenceRelationship>();
            ApprovedObjects = new List<IfcRelAssociatesApproval>();
            ApprovedResources = new List<IfcResourceApprovalRelationship>();
            IsRelatedWith = new List<IfcApprovalRelationship>();
            Relates = new List<IfcApprovalRelationship>();
        }

	    /// <summary>
	    ///     Construct a IfcApproval with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcApproval(IfcIdentifier identifier, IfcLabel name, IfcText description, IfcDateTime timeOfApproval,
            IfcLabel status, IfcLabel level, IfcText qualifier, IfcActorSelect requestingApproval,
            IfcActorSelect givingApproval)
        {
            HasExternalReferences = new List<IfcExternalReferenceRelationship>();
            ApprovedObjects = new List<IfcRelAssociatesApproval>();
            ApprovedResources = new List<IfcResourceApprovalRelationship>();
            IsRelatedWith = new List<IfcApprovalRelationship>();
            Relates = new List<IfcApprovalRelationship>();

            Identifier = identifier;
            Name = name;
            Description = description;
            TimeOfApproval = timeOfApproval;
            Status = status;
            Level = level;
            Qualifier = qualifier;
            RequestingApproval = requestingApproval;
            GivingApproval = givingApproval;
        }

        public IfcIdentifier Identifier { get; set; } // optional
        public IfcLabel Name { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public IfcDateTime TimeOfApproval { get; set; } // optional
        public IfcLabel Status { get; set; } // optional
        public IfcLabel Level { get; set; } // optional
        public IfcText Qualifier { get; set; } // optional
        public IfcActorSelect RequestingApproval { get; set; } // optional
        public IfcActorSelect GivingApproval { get; set; } // optional
        public List<IfcExternalReferenceRelationship> HasExternalReferences { get; set; } // inverse
        public List<IfcRelAssociatesApproval> ApprovedObjects { get; set; } // inverse
        public List<IfcResourceApprovalRelationship> ApprovedResources { get; set; } // inverse
        public List<IfcApprovalRelationship> IsRelatedWith { get; set; } // inverse
        public List<IfcApprovalRelationship> Relates { get; set; } // inverse

        public static IfcApproval FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcApproval>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Identifier != null ? Identifier.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            TimeOfApproval != null ? TimeOfApproval.ToStepValue() : "$",
	            Status != null ? Status.ToStepValue() : "$",
	            Level != null ? Level.ToStepValue() : "$",
	            Qualifier != null ? Qualifier.ToStepValue() : "$",
	            RequestingApproval != null ? RequestingApproval.ToStepValue() : "$",
	            GivingApproval != null ? GivingApproval.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}