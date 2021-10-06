using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpointoncurve.htm" />
	/// </summary>
	public class IfcPointOnCurve : IfcPoint
    {
	    /// <summary>
	    ///     Construct a IfcPointOnCurve with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPointOnCurve(IfcCurve basisCurve, IfcParameterValue pointParameter)
        {
            BasisCurve = basisCurve;
            PointParameter = pointParameter;
        }

        public IfcCurve BasisCurve { get; set; }
        public IfcParameterValue PointParameter { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcPointOnCurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPointOnCurve>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                BasisCurve != null ? BasisCurve.ToStepValue() : "$",
                PointParameter != null ? PointParameter.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}