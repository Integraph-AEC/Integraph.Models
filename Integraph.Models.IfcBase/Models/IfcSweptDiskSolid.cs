using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsweptdisksolid.htm" />
	/// </summary>
	public class IfcSweptDiskSolid : IfcSolidModel
    {
	    /// <summary>
	    ///     Construct a IfcSweptDiskSolid with all required attributes.
	    /// </summary>
	    public IfcSweptDiskSolid(IfcCurve directrix, IfcPositiveLengthMeasure radius)
        {
            Directrix = directrix;
            Radius = radius;
        }

	    /// <summary>
	    ///     Construct a IfcSweptDiskSolid with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSweptDiskSolid(IfcCurve directrix, IfcPositiveLengthMeasure radius,
            IfcPositiveLengthMeasure innerRadius, IfcParameterValue startParam, IfcParameterValue endParam)
        {
            Directrix = directrix;
            Radius = radius;
            InnerRadius = innerRadius;
            StartParam = startParam;
            EndParam = endParam;
        }

        public IfcCurve Directrix { get; set; }
        public IfcPositiveLengthMeasure Radius { get; set; }
        public IfcPositiveLengthMeasure InnerRadius { get; set; } // optional
        public IfcParameterValue StartParam { get; set; } // optional
        public IfcParameterValue EndParam { get; set; } // optional

        public new static IfcSweptDiskSolid FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSweptDiskSolid>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Directrix != null ? Directrix.ToStepValue() : "$",
	            Radius != null ? Radius.ToStepValue() : "$",
	            InnerRadius != null ? InnerRadius.ToStepValue() : "$",
	            StartParam != null ? StartParam.ToStepValue() : "$",
	            EndParam != null ? EndParam.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}