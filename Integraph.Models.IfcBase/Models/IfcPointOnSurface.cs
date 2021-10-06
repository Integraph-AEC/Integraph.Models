using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpointonsurface.htm" />
	/// </summary>
	public class IfcPointOnSurface : IfcPoint
    {
	    /// <summary>
	    ///     Construct a IfcPointOnSurface with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPointOnSurface(IfcSurface basisSurface, IfcParameterValue pointParameterU,
            IfcParameterValue pointParameterV)
        {
            BasisSurface = basisSurface;
            PointParameterU = pointParameterU;
            PointParameterV = pointParameterV;
        }

        public IfcSurface BasisSurface { get; set; }
        public IfcParameterValue PointParameterU { get; set; }
        public IfcParameterValue PointParameterV { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcPointOnSurface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPointOnSurface>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                BasisSurface != null ? BasisSurface.ToStepValue() : "$",
                PointParameterU != null ? PointParameterU.ToStepValue() : "$",
                PointParameterV != null ? PointParameterV.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}