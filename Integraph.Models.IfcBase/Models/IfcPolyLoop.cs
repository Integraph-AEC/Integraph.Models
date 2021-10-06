using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpolyloop.htm" />
	/// </summary>
	public class IfcPolyLoop : IfcLoop
    {
	    /// <summary>
	    ///     Construct a IfcPolyLoop with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPolyLoop(List<IfcCartesianPoint> polygon)
        {
            Polygon = polygon;
        }

        public List<IfcCartesianPoint> Polygon { get; set; }

        public new static IfcPolyLoop FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPolyLoop>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Polygon != null ? Polygon.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}