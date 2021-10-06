using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsweptdisksolidpolygonal.htm" />
	/// </summary>
	public class IfcSweptDiskSolidPolygonal : IfcSweptDiskSolid
    {
	    /// <summary>
	    ///     Construct a IfcSweptDiskSolidPolygonal with all required attributes.
	    /// </summary>
	    public IfcSweptDiskSolidPolygonal(IfcCurve directrix, IfcPositiveLengthMeasure radius) : base(directrix, radius)
        {
        }

	    /// <summary>
	    ///     Construct a IfcSweptDiskSolidPolygonal with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSweptDiskSolidPolygonal(IfcCurve directrix, IfcPositiveLengthMeasure radius,
            IfcPositiveLengthMeasure innerRadius, IfcParameterValue startParam, IfcParameterValue endParam,
            IfcPositiveLengthMeasure filletRadius) : base(directrix, radius, innerRadius, startParam, endParam)
        {
            FilletRadius = filletRadius;
        }

        public IfcPositiveLengthMeasure FilletRadius { get; set; } // optional

        public new static IfcSweptDiskSolidPolygonal FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSweptDiskSolidPolygonal>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Directrix != null ? Directrix.ToStepValue() : "$",
	            Radius != null ? Radius.ToStepValue() : "$",
	            InnerRadius != null ? InnerRadius.ToStepValue() : "$",
	            StartParam != null ? StartParam.ToStepValue() : "$",
	            EndParam != null ? EndParam.ToStepValue() : "$",
	            FilletRadius != null ? FilletRadius.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}