using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcworktime.htm" />
	/// </summary>
	public class IfcWorkTime : IfcSchedulingTime
    {
	    /// <summary>
	    ///     Construct a IfcWorkTime with all required attributes.
	    /// </summary>
	    public IfcWorkTime()
        {
        }

	    /// <summary>
	    ///     Construct a IfcWorkTime with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcWorkTime(IfcLabel name, IfcDataOriginEnum dataOrigin, IfcLabel userDefinedDataOrigin,
            IfcRecurrencePattern recurrencePattern, IfcDate start, IfcDate finish) : base(name, dataOrigin,
            userDefinedDataOrigin)
        {
            RecurrencePattern = recurrencePattern;
            Start = start;
            Finish = finish;
        }

        public IfcRecurrencePattern RecurrencePattern { get; set; } // optional
        public IfcDate Start { get; set; } // optional
        public IfcDate Finish { get; set; } // optional

        public new static IfcWorkTime FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcWorkTime>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            DataOrigin.ToStepValue(),
	            UserDefinedDataOrigin != null ? UserDefinedDataOrigin.ToStepValue() : "$",
	            RecurrencePattern != null ? RecurrencePattern.ToStepValue() : "$",
	            Start != null ? Start.ToStepValue() : "$",
	            Finish != null ? Finish.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}