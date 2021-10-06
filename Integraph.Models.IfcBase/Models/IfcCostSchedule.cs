using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccostschedule.htm" />
	/// </summary>
	public class IfcCostSchedule : IfcControl
    {
	    /// <summary>
	    ///     Construct a IfcCostSchedule with all required attributes.
	    /// </summary>
	    public IfcCostSchedule(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcCostSchedule with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCostSchedule(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcIdentifier identification,
            IfcCostScheduleTypeEnum predefinedType, IfcLabel status, IfcDateTime submittedOn, IfcDateTime updateDate) :
            base(globalId, ownerHistory, name, description, objectType, identification)
        {
            PredefinedType = predefinedType;
            Status = status;
            SubmittedOn = submittedOn;
            UpdateDate = updateDate;
        }

        public IfcCostScheduleTypeEnum? PredefinedType { get; set; } // optional
        public IfcLabel Status { get; set; } // optional
        public IfcDateTime SubmittedOn { get; set; } // optional
        public IfcDateTime UpdateDate { get; set; } // optional

        public new static IfcCostSchedule FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCostSchedule>(json);
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
	            Identification != null ? Identification.ToStepValue() : "$",
	            PredefinedType.ToStepValue(),
	            Status != null ? Status.ToStepValue() : "$",
	            SubmittedOn != null ? SubmittedOn.ToStepValue() : "$",
	            UpdateDate != null ? UpdateDate.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}