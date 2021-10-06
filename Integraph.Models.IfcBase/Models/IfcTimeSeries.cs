using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctimeseries.htm" />
	/// </summary>
	public abstract class IfcTimeSeries : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcTimeSeries with all required attributes.
	    /// </summary>
	    public IfcTimeSeries(IfcLabel name, IfcDateTime startTime, IfcDateTime endTime,
            IfcTimeSeriesDataTypeEnum timeSeriesDataType, IfcDataOriginEnum dataOrigin)
        {
            HasExternalReference = new List<IfcExternalReferenceRelationship>();

            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            TimeSeriesDataType = timeSeriesDataType;
            DataOrigin = dataOrigin;
        }

	    /// <summary>
	    ///     Construct a IfcTimeSeries with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTimeSeries(IfcLabel name, IfcText description, IfcDateTime startTime, IfcDateTime endTime,
            IfcTimeSeriesDataTypeEnum timeSeriesDataType, IfcDataOriginEnum dataOrigin, IfcLabel userDefinedDataOrigin,
            IfcUnit unit)
        {
            HasExternalReference = new List<IfcExternalReferenceRelationship>();

            Name = name;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
            TimeSeriesDataType = timeSeriesDataType;
            DataOrigin = dataOrigin;
            UserDefinedDataOrigin = userDefinedDataOrigin;
            Unit = unit;
        }

        public IfcLabel Name { get; set; }
        public IfcText Description { get; set; } // optional
        public IfcDateTime StartTime { get; set; }
        public IfcDateTime EndTime { get; set; }
        public IfcTimeSeriesDataTypeEnum? TimeSeriesDataType { get; set; }
        public IfcDataOriginEnum? DataOrigin { get; set; }
        public IfcLabel UserDefinedDataOrigin { get; set; } // optional
        public IfcUnit Unit { get; set; } // optional
        public List<IfcExternalReferenceRelationship> HasExternalReference { get; set; } // inverse

        public static IfcTimeSeries FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTimeSeries>(json);
        }
    }
}