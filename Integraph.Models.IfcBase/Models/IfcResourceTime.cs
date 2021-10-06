using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcresourcetime.htm" />
	/// </summary>
	public class IfcResourceTime : IfcSchedulingTime
    {
	    /// <summary>
	    ///     Construct a IfcResourceTime with all required attributes.
	    /// </summary>
	    public IfcResourceTime()
        {
        }

	    /// <summary>
	    ///     Construct a IfcResourceTime with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcResourceTime(IfcLabel name, IfcDataOriginEnum dataOrigin, IfcLabel userDefinedDataOrigin,
            IfcDuration scheduleWork, IfcPositiveRatioMeasure scheduleUsage, IfcDateTime scheduleStart,
            IfcDateTime scheduleFinish, IfcLabel scheduleContour, IfcDuration levelingDelay, IfcBoolean isOverAllocated,
            IfcDateTime statusTime, IfcDuration actualWork, IfcPositiveRatioMeasure actualUsage,
            IfcDateTime actualStart, IfcDateTime actualFinish, IfcDuration remainingWork,
            IfcPositiveRatioMeasure remainingUsage, IfcPositiveRatioMeasure completion) : base(name, dataOrigin,
            userDefinedDataOrigin)
        {
            ScheduleWork = scheduleWork;
            ScheduleUsage = scheduleUsage;
            ScheduleStart = scheduleStart;
            ScheduleFinish = scheduleFinish;
            ScheduleContour = scheduleContour;
            LevelingDelay = levelingDelay;
            IsOverAllocated = isOverAllocated;
            StatusTime = statusTime;
            ActualWork = actualWork;
            ActualUsage = actualUsage;
            ActualStart = actualStart;
            ActualFinish = actualFinish;
            RemainingWork = remainingWork;
            RemainingUsage = remainingUsage;
            Completion = completion;
        }

        public IfcDuration ScheduleWork { get; set; } // optional
        public IfcPositiveRatioMeasure ScheduleUsage { get; set; } // optional
        public IfcDateTime ScheduleStart { get; set; } // optional
        public IfcDateTime ScheduleFinish { get; set; } // optional
        public IfcLabel ScheduleContour { get; set; } // optional
        public IfcDuration LevelingDelay { get; set; } // optional
        public IfcBoolean IsOverAllocated { get; set; } // optional
        public IfcDateTime StatusTime { get; set; } // optional
        public IfcDuration ActualWork { get; set; } // optional
        public IfcPositiveRatioMeasure ActualUsage { get; set; } // optional
        public IfcDateTime ActualStart { get; set; } // optional
        public IfcDateTime ActualFinish { get; set; } // optional
        public IfcDuration RemainingWork { get; set; } // optional
        public IfcPositiveRatioMeasure RemainingUsage { get; set; } // optional
        public IfcPositiveRatioMeasure Completion { get; set; } // optional

        public new static IfcResourceTime FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcResourceTime>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            DataOrigin.ToStepValue(),
	            UserDefinedDataOrigin != null ? UserDefinedDataOrigin.ToStepValue() : "$",
	            ScheduleWork != null ? ScheduleWork.ToStepValue() : "$",
	            ScheduleUsage != null ? ScheduleUsage.ToStepValue() : "$",
	            ScheduleStart != null ? ScheduleStart.ToStepValue() : "$",
	            ScheduleFinish != null ? ScheduleFinish.ToStepValue() : "$",
	            ScheduleContour != null ? ScheduleContour.ToStepValue() : "$",
	            LevelingDelay != null ? LevelingDelay.ToStepValue() : "$",
	            IsOverAllocated != null ? IsOverAllocated.ToStepValue() : "$",
	            StatusTime != null ? StatusTime.ToStepValue() : "$",
	            ActualWork != null ? ActualWork.ToStepValue() : "$",
	            ActualUsage != null ? ActualUsage.ToStepValue() : "$",
	            ActualStart != null ? ActualStart.ToStepValue() : "$",
	            ActualFinish != null ? ActualFinish.ToStepValue() : "$",
	            RemainingWork != null ? RemainingWork.ToStepValue() : "$",
	            RemainingUsage != null ? RemainingUsage.ToStepValue() : "$",
	            Completion != null ? Completion.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}