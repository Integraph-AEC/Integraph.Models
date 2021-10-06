using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifceventtime.htm" />
	/// </summary>
	public class IfcEventTime : IfcSchedulingTime
    {
	    /// <summary>
	    ///     Construct a IfcEventTime with all required attributes.
	    /// </summary>
	    public IfcEventTime()
        {
        }

	    /// <summary>
	    ///     Construct a IfcEventTime with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcEventTime(IfcLabel name, IfcDataOriginEnum dataOrigin, IfcLabel userDefinedDataOrigin,
            IfcDateTime actualDate, IfcDateTime earlyDate, IfcDateTime lateDate, IfcDateTime scheduleDate) : base(name,
            dataOrigin, userDefinedDataOrigin)
        {
            ActualDate = actualDate;
            EarlyDate = earlyDate;
            LateDate = lateDate;
            ScheduleDate = scheduleDate;
        }

        public IfcDateTime ActualDate { get; set; } // optional
        public IfcDateTime EarlyDate { get; set; } // optional
        public IfcDateTime LateDate { get; set; } // optional
        public IfcDateTime ScheduleDate { get; set; } // optional

        public new static IfcEventTime FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcEventTime>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            DataOrigin.ToStepValue(),
	            UserDefinedDataOrigin != null ? UserDefinedDataOrigin.ToStepValue() : "$",
	            ActualDate != null ? ActualDate.ToStepValue() : "$",
	            EarlyDate != null ? EarlyDate.ToStepValue() : "$",
	            LateDate != null ? LateDate.ToStepValue() : "$",
	            ScheduleDate != null ? ScheduleDate.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}