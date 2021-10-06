using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctimeperiod.htm" />
	/// </summary>
	public class IfcTimePeriod : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcTimePeriod with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTimePeriod(IfcTime startTime, IfcTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public IfcTime StartTime { get; set; }
        public IfcTime EndTime { get; set; }

        public static IfcTimePeriod FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTimePeriod>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            StartTime != null ? StartTime.ToStepValue() : "$",
	            EndTime != null ? EndTime.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}