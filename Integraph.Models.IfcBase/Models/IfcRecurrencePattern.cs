using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrecurrencepattern.htm" />
	/// </summary>
	public class IfcRecurrencePattern : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcRecurrencePattern with all required attributes.
	    /// </summary>
	    public IfcRecurrencePattern(IfcRecurrenceTypeEnum recurrenceType)
        {
            DayComponent = new List<IfcDayInMonthNumber>();
            WeekdayComponent = new List<IfcDayInWeekNumber>();
            MonthComponent = new List<IfcMonthInYearNumber>();
            TimePeriods = new List<IfcTimePeriod>();

            RecurrenceType = recurrenceType;
        }

	    /// <summary>
	    ///     Construct a IfcRecurrencePattern with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRecurrencePattern(IfcRecurrenceTypeEnum recurrenceType, List<IfcDayInMonthNumber> dayComponent,
            List<IfcDayInWeekNumber> weekdayComponent, List<IfcMonthInYearNumber> monthComponent, IfcInteger position,
            IfcInteger interval, IfcInteger occurrences, List<IfcTimePeriod> timePeriods)
        {
            RecurrenceType = recurrenceType;
            DayComponent = dayComponent;
            WeekdayComponent = weekdayComponent;
            MonthComponent = monthComponent;
            Position = position;
            Interval = interval;
            Occurrences = occurrences;
            TimePeriods = timePeriods;
        }

        public IfcRecurrenceTypeEnum? RecurrenceType { get; set; }
        public List<IfcDayInMonthNumber> DayComponent { get; set; } // optional
        public List<IfcDayInWeekNumber> WeekdayComponent { get; set; } // optional
        public List<IfcMonthInYearNumber> MonthComponent { get; set; } // optional
        public IfcInteger Position { get; set; } // optional
        public IfcInteger Interval { get; set; } // optional
        public IfcInteger Occurrences { get; set; } // optional
        public List<IfcTimePeriod> TimePeriods { get; set; } // optional

        public static IfcRecurrencePattern FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRecurrencePattern>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            RecurrenceType.ToStepValue(),
	            DayComponent != null ? DayComponent.ToStepValue() : "$",
	            WeekdayComponent != null ? WeekdayComponent.ToStepValue() : "$",
	            MonthComponent != null ? MonthComponent.ToStepValue() : "$",
	            Position != null ? Position.ToStepValue() : "$",
	            Interval != null ? Interval.ToStepValue() : "$",
	            Occurrences != null ? Occurrences.ToStepValue() : "$",
	            TimePeriods != null ? TimePeriods.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}