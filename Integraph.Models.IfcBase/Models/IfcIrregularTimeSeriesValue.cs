using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcirregulartimeseriesvalue.htm" />
	/// </summary>
	public class IfcIrregularTimeSeriesValue : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcIrregularTimeSeriesValue with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcIrregularTimeSeriesValue(IfcDateTime timeStamp, List<IfcValue> listValues)
        {
            TimeStamp = timeStamp;
            ListValues = listValues;
        }

        public IfcDateTime TimeStamp { get; set; }
        public List<IfcValue> ListValues { get; set; }

        public static IfcIrregularTimeSeriesValue FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIrregularTimeSeriesValue>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            TimeStamp != null ? TimeStamp.ToStepValue() : "$",
	            ListValues != null ? ListValues.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}