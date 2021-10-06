using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctasktime.htm" />
	/// </summary>
	public class IfcTaskTime : IfcSchedulingTime
    {
	    /// <summary>
	    ///     Construct a IfcTaskTime with all required attributes.
	    /// </summary>
	    public IfcTaskTime()
        {
        }

	    /// <summary>
	    ///     Construct a IfcTaskTime with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTaskTime(IfcLabel name, IfcDataOriginEnum dataOrigin, IfcLabel userDefinedDataOrigin,
            IfcTaskDurationEnum durationType, IfcDuration scheduleDuration, IfcDateTime scheduleStart,
            IfcDateTime scheduleFinish, IfcDateTime earlyStart, IfcDateTime earlyFinish, IfcDateTime lateStart,
            IfcDateTime lateFinish, IfcDuration freeFloat, IfcDuration totalFloat, IfcBoolean isCritical,
            IfcDateTime statusTime, IfcDuration actualDuration, IfcDateTime actualStart, IfcDateTime actualFinish,
            IfcDuration remainingTime, IfcPositiveRatioMeasure completion) : base(name, dataOrigin,
            userDefinedDataOrigin)
        {
            DurationType = durationType;
            ScheduleDuration = scheduleDuration;
            ScheduleStart = scheduleStart;
            ScheduleFinish = scheduleFinish;
            EarlyStart = earlyStart;
            EarlyFinish = earlyFinish;
            LateStart = lateStart;
            LateFinish = lateFinish;
            FreeFloat = freeFloat;
            TotalFloat = totalFloat;
            IsCritical = isCritical;
            StatusTime = statusTime;
            ActualDuration = actualDuration;
            ActualStart = actualStart;
            ActualFinish = actualFinish;
            RemainingTime = remainingTime;
            Completion = completion;
        }

        public IfcTaskDurationEnum? DurationType { get; set; } // optional
        public IfcDuration ScheduleDuration { get; set; } // optional
        public IfcDateTime ScheduleStart { get; set; } // optional
        public IfcDateTime ScheduleFinish { get; set; } // optional
        public IfcDateTime EarlyStart { get; set; } // optional
        public IfcDateTime EarlyFinish { get; set; } // optional
        public IfcDateTime LateStart { get; set; } // optional
        public IfcDateTime LateFinish { get; set; } // optional
        public IfcDuration FreeFloat { get; set; } // optional
        public IfcDuration TotalFloat { get; set; } // optional
        public IfcBoolean IsCritical { get; set; } // optional
        public IfcDateTime StatusTime { get; set; } // optional
        public IfcDuration ActualDuration { get; set; } // optional
        public IfcDateTime ActualStart { get; set; } // optional
        public IfcDateTime ActualFinish { get; set; } // optional
        public IfcDuration RemainingTime { get; set; } // optional
        public IfcPositiveRatioMeasure Completion { get; set; } // optional

        public new static IfcTaskTime FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTaskTime>(json);
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
	            Completion != null ? Completion.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}