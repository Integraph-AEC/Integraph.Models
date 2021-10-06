using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcownerhistory.htm" />
	/// </summary>
	public class IfcOwnerHistory : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcOwnerHistory with all required attributes.
	    /// </summary>
	    public IfcOwnerHistory(IfcPersonAndOrganization owningUser, IfcApplication owningApplication,
            IfcTimeStamp creationDate)
        {
            OwningUser = owningUser;
            OwningApplication = owningApplication;
            CreationDate = creationDate;
        }

	    /// <summary>
	    ///     Construct a IfcOwnerHistory with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcOwnerHistory(IfcPersonAndOrganization owningUser, IfcApplication owningApplication,
            IfcStateEnum state, IfcChangeActionEnum changeAction, IfcTimeStamp lastModifiedDate,
            IfcPersonAndOrganization lastModifyingUser, IfcApplication lastModifyingApplication,
            IfcTimeStamp creationDate)
        {
            OwningUser = owningUser;
            OwningApplication = owningApplication;
            State = state;
            ChangeAction = changeAction;
            LastModifiedDate = lastModifiedDate;
            LastModifyingUser = lastModifyingUser;
            LastModifyingApplication = lastModifyingApplication;
            CreationDate = creationDate;
        }

        public IfcPersonAndOrganization OwningUser { get; set; }
        public IfcApplication OwningApplication { get; set; }
        public IfcStateEnum? State { get; set; } // optional
        public IfcChangeActionEnum? ChangeAction { get; set; } // optional
        public IfcTimeStamp LastModifiedDate { get; set; } // optional
        public IfcPersonAndOrganization LastModifyingUser { get; set; } // optional
        public IfcApplication LastModifyingApplication { get; set; } // optional
        public IfcTimeStamp CreationDate { get; set; }

        public static IfcOwnerHistory FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcOwnerHistory>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                OwningUser != null ? OwningUser.ToStepValue() : "$",
                OwningApplication != null ? OwningApplication.ToStepValue() : "$",
                State.ToStepValue(),
                ChangeAction.ToStepValue(),
                LastModifiedDate != null ? LastModifiedDate.ToStepValue() : "$",
                LastModifyingUser != null ? LastModifyingUser.ToStepValue() : "$",
                LastModifyingApplication != null ? LastModifyingApplication.ToStepValue() : "$",
                CreationDate != null ? CreationDate.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}