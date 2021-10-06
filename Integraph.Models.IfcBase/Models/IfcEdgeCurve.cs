using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcedgecurve.htm" />
	/// </summary>
	public class IfcEdgeCurve : IfcEdge
    {
	    /// <summary>
	    ///     Construct a IfcEdgeCurve with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcEdgeCurve(IfcVertex edgeStart, IfcVertex edgeEnd, IfcCurve edgeGeometry, IfcBoolean sameSense) : base(
            edgeStart, edgeEnd)
        {
            EdgeGeometry = edgeGeometry;
            SameSense = sameSense;
        }

        public IfcCurve EdgeGeometry { get; set; }
        public IfcBoolean SameSense { get; set; }

        public new static IfcEdgeCurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcEdgeCurve>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                EdgeStart != null ? EdgeStart.ToStepValue() : "$",
                EdgeEnd != null ? EdgeEnd.ToStepValue() : "$",
                EdgeGeometry != null ? EdgeGeometry.ToStepValue() : "$",
                SameSense != null ? SameSense.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}