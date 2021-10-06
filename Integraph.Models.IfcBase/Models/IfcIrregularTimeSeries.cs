using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcirregulartimeseries.htm" />
	/// </summary>
	public class IfcIrregularTimeSeries : IfcTimeSeries
    {
	    /// <summary>
	    ///     Construct a IfcIrregularTimeSeries with all required attributes.
	    /// </summary>
	    public IfcIrregularTimeSeries(IfcLabel name, IfcDateTime startTime, IfcDateTime endTime,
            IfcTimeSeriesDataTypeEnum timeSeriesDataType, IfcDataOriginEnum dataOrigin,
            List<IfcIrregularTimeSeriesValue> values) : base(name, startTime, endTime, timeSeriesDataType, dataOrigin)
        {
            Values = values;
        }

	    /// <summary>
	    ///     Construct a IfcIrregularTimeSeries with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcIrregularTimeSeries(IfcLabel name, IfcText description, IfcDateTime startTime, IfcDateTime endTime,
            IfcTimeSeriesDataTypeEnum timeSeriesDataType, IfcDataOriginEnum dataOrigin, IfcLabel userDefinedDataOrigin,
            IfcUnit unit, List<IfcIrregularTimeSeriesValue> values) : base(name, description, startTime, endTime,
            timeSeriesDataType, dataOrigin, userDefinedDataOrigin, unit)
        {
            Values = values;
        }

        public List<IfcIrregularTimeSeriesValue> Values { get; set; }

        public new static IfcIrregularTimeSeries FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIrregularTimeSeries>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                StartTime != null ? StartTime.ToStepValue() : "$",
                EndTime != null ? EndTime.ToStepValue() : "$",
                TimeSeriesDataType.ToStepValue(),
                DataOrigin.ToStepValue(),
                UserDefinedDataOrigin != null ? UserDefinedDataOrigin.ToStepValue() : "$",
                Unit != null ? Unit.ToStepValue() : "$",
                Values != null ? Values.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}