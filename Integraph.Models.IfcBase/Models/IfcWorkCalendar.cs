using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcworkcalendar.htm" />
	/// </summary>
	public class IfcWorkCalendar : IfcControl
    {
	    /// <summary>
	    ///     Construct a IfcWorkCalendar with all required attributes.
	    /// </summary>
	    public IfcWorkCalendar(IfcGloballyUniqueId globalId) : base(globalId)
        {
            WorkingTimes = new List<IfcWorkTime>();
            ExceptionTimes = new List<IfcWorkTime>();
        }

	    /// <summary>
	    ///     Construct a IfcWorkCalendar with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcWorkCalendar(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcIdentifier identification, List<IfcWorkTime> workingTimes,
            List<IfcWorkTime> exceptionTimes, IfcWorkCalendarTypeEnum predefinedType) : base(globalId, ownerHistory,
            name, description, objectType, identification)
        {
            WorkingTimes = workingTimes;
            ExceptionTimes = exceptionTimes;
            PredefinedType = predefinedType;
        }

        public List<IfcWorkTime> WorkingTimes { get; set; } // optional
        public List<IfcWorkTime> ExceptionTimes { get; set; } // optional
        public IfcWorkCalendarTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcWorkCalendar FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcWorkCalendar>(json);
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
	            WorkingTimes != null ? WorkingTimes.ToStepValue() : "$",
	            ExceptionTimes != null ? ExceptionTimes.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}