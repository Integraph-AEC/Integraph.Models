using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcworkschedule.htm" />
	/// </summary>
	public class IfcWorkSchedule : IfcWorkControl
    {
	    /// <summary>
	    ///     Construct a IfcWorkSchedule with all required attributes.
	    /// </summary>
	    public IfcWorkSchedule(IfcGloballyUniqueId globalId, IfcDateTime creationDate, IfcDateTime startTime) : base(
            globalId, creationDate, startTime)
        {
        }

	    /// <summary>
	    ///     Construct a IfcWorkSchedule with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcWorkSchedule(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcIdentifier identification, IfcDateTime creationDate,
            List<IfcPerson> creators, IfcLabel purpose, IfcDuration duration, IfcDuration totalFloat,
            IfcDateTime startTime, IfcDateTime finishTime, IfcWorkScheduleTypeEnum predefinedType) : base(globalId,
            ownerHistory, name, description, objectType, identification, creationDate, creators, purpose, duration,
            totalFloat, startTime, finishTime)
        {
            PredefinedType = predefinedType;
        }

        public IfcWorkScheduleTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcWorkSchedule FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcWorkSchedule>(json);
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
	            CreationDate != null ? CreationDate.ToStepValue() : "$",
	            Creators != null ? Creators.ToStepValue() : "$",
	            Purpose != null ? Purpose.ToStepValue() : "$",
	            Duration != null ? Duration.ToStepValue() : "$",
	            TotalFloat != null ? TotalFloat.ToStepValue() : "$",
	            StartTime != null ? StartTime.ToStepValue() : "$",
	            FinishTime != null ? FinishTime.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}