using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctasktimerecurring.htm" />
	/// </summary>
	public class IfcTaskTimeRecurring : IfcTaskTime
    {
	    /// <summary>
	    ///     Construct a IfcTaskTimeRecurring with all required attributes.
	    /// </summary>
	    public IfcTaskTimeRecurring(IfcRecurrencePattern recurrence)
        {
            Recurrence = recurrence;
        }

	    /// <summary>
	    ///     Construct a IfcTaskTimeRecurring with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTaskTimeRecurring(IfcLabel name, IfcDataOriginEnum dataOrigin, IfcLabel userDefinedDataOrigin,
            IfcTaskDurationEnum durationType, IfcDuration scheduleDuration, IfcDateTime scheduleStart,
            IfcDateTime scheduleFinish, IfcDateTime earlyStart, IfcDateTime earlyFinish, IfcDateTime lateStart,
            IfcDateTime lateFinish, IfcDuration freeFloat, IfcDuration totalFloat, IfcBoolean isCritical,
            IfcDateTime statusTime, IfcDuration actualDuration, IfcDateTime actualStart, IfcDateTime actualFinish,
            IfcDuration remainingTime, IfcPositiveRatioMeasure completion, IfcRecurrencePattern recurrence) : base(name,
            dataOrigin, userDefinedDataOrigin, durationType, scheduleDuration, scheduleStart, scheduleFinish,
            earlyStart, earlyFinish, lateStart, lateFinish, freeFloat, totalFloat, isCritical, statusTime,
            actualDuration, actualStart, actualFinish, remainingTime, completion)
        {
            Recurrence = recurrence;
        }

        public IfcRecurrencePattern Recurrence { get; set; }

        public new static IfcTaskTimeRecurring FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTaskTimeRecurring>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            DataOrigin.ToStepValue(),
	            UserDefinedDataOrigin != null ? UserDefinedDataOrigin.ToStepValue() : "$",
	            DurationType.ToStepValue(),
	            ScheduleDuration != null ? ScheduleDuration.ToStepValue() : "$",
	            ScheduleStart != null ? ScheduleStart.ToStepValue() : "$",
	            ScheduleFinish != null ? ScheduleFinish.ToStepValue() : "$",
	            EarlyStart != null ? EarlyStart.ToStepValue() : "$",
	            EarlyFinish != null ? EarlyFinish.ToStepValue() : "$",
	            LateStart != null ? LateStart.ToStepValue() : "$",
	            LateFinish != null ? LateFinish.ToStepValue() : "$",
	            FreeFloat != null ? FreeFloat.ToStepValue() : "$",
	            TotalFloat != null ? TotalFloat.ToStepValue() : "$",
	            IsCritical != null ? IsCritical.ToStepValue() : "$",
	            StatusTime != null ? StatusTime.ToStepValue() : "$",
	            ActualDuration != null ? ActualDuration.ToStepValue() : "$",
	            ActualStart != null ? ActualStart.ToStepValue() : "$",
	            ActualFinish != null ? ActualFinish.ToStepValue() : "$",
	            RemainingTime != null ? RemainingTime.ToStepValue() : "$",
	            Completion != null ? Completion.ToStepValue() : "$",
	            Recurrence != null ? Recurrence.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}