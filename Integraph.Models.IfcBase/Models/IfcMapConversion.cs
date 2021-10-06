using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmapconversion.htm" />
	/// </summary>
	public class IfcMapConversion : IfcCoordinateOperation
    {
	    /// <summary>
	    ///     Construct a IfcMapConversion with all required attributes.
	    /// </summary>
	    public IfcMapConversion(IfcCoordinateReferenceSystemSelect sourceCrs, IfcCoordinateReferenceSystem targetCrs,
            IfcLengthMeasure eastings, IfcLengthMeasure northings, IfcLengthMeasure orthogonalHeight) : base(sourceCrs,
            targetCrs)
        {
            Eastings = eastings;
            Northings = northings;
            OrthogonalHeight = orthogonalHeight;
        }

	    /// <summary>
	    ///     Construct a IfcMapConversion with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMapConversion(IfcCoordinateReferenceSystemSelect sourceCrs, IfcCoordinateReferenceSystem targetCrs,
            IfcLengthMeasure eastings, IfcLengthMeasure northings, IfcLengthMeasure orthogonalHeight,
            IfcReal xAxisAbscissa, IfcReal xAxisOrdinate, IfcReal scale) : base(sourceCrs, targetCrs)
        {
            Eastings = eastings;
            Northings = northings;
            OrthogonalHeight = orthogonalHeight;
            XAxisAbscissa = xAxisAbscissa;
            XAxisOrdinate = xAxisOrdinate;
            Scale = scale;
        }

        public IfcLengthMeasure Eastings { get; set; }
        public IfcLengthMeasure Northings { get; set; }
        public IfcLengthMeasure OrthogonalHeight { get; set; }
        public IfcReal XAxisAbscissa { get; set; } // optional
        public IfcReal XAxisOrdinate { get; set; } // optional
        public IfcReal Scale { get; set; } // optional

        public new static IfcMapConversion FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMapConversion>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                SourceCrs != null ? SourceCrs.ToStepValue() : "$",
                TargetCrs != null ? TargetCrs.ToStepValue() : "$",
                Eastings != null ? Eastings.ToStepValue() : "$",
                Northings != null ? Northings.ToStepValue() : "$",
                OrthogonalHeight != null ? OrthogonalHeight.ToStepValue() : "$",
                XAxisAbscissa != null ? XAxisAbscissa.ToStepValue() : "$",
                XAxisOrdinate != null ? XAxisOrdinate.ToStepValue() : "$",
                Scale != null ? Scale.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}