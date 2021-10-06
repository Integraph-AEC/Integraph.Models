using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctimeseriesvalue.htm" />
	/// </summary>
	public class IfcTimeSeriesValue : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcTimeSeriesValue with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTimeSeriesValue(List<IfcValue> listValues)
        {
            ListValues = listValues;
        }

        public List<IfcValue> ListValues { get; set; }

        public static IfcTimeSeriesValue FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTimeSeriesValue>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {ListValues != null ? ListValues.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}