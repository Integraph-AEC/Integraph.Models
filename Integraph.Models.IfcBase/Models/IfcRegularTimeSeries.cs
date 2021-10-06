using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcregulartimeseries.htm" />
	/// </summary>
	public class IfcRegularTimeSeries : IfcTimeSeries
    {
	    /// <summary>
	    ///     Construct a IfcRegularTimeSeries with all required attributes.
	    /// </summary>
	    public IfcRegularTimeSeries(IfcLabel name, IfcDateTime startTime, IfcDateTime endTime,
            IfcTimeSeriesDataTypeEnum timeSeriesDataType, IfcDataOriginEnum dataOrigin, IfcTimeMeasure timeStep,
            List<IfcTimeSeriesValue> values) : base(name, startTime, endTime, timeSeriesDataType, dataOrigin)
        {
            TimeStep = timeStep;
            Values = values;
        }

	    /// <summary>
	    ///     Construct a IfcRegularTimeSeries with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRegularTimeSeries(IfcLabel name, IfcText description, IfcDateTime startTime, IfcDateTime endTime,
            IfcTimeSeriesDataTypeEnum timeSeriesDataType, IfcDataOriginEnum dataOrigin, IfcLabel userDefinedDataOrigin,
            IfcUnit unit, IfcTimeMeasure timeStep, List<IfcTimeSeriesValue> values) : base(name, description, startTime,
            endTime, timeSeriesDataType, dataOrigin, userDefinedDataOrigin, unit)
        {
            TimeStep = timeStep;
            Values = values;
        }

        public IfcTimeMeasure TimeStep { get; set; }
        public List<IfcTimeSeriesValue> Values { get; set; }

        public new static IfcRegularTimeSeries FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRegularTimeSeries>(json);
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
                TimeStep != null ? TimeStep.ToStepValue() : "$",
                Values != null ? Values.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}