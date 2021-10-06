using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpolyline.htm" />
	/// </summary>
	public class IfcPolyline : IfcBoundedCurve
    {
	    /// <summary>
	    ///     Construct a IfcPolyline with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPolyline(List<IfcCartesianPoint> points)
        {
            Points = points;
        }

        public List<IfcCartesianPoint> Points { get; set; }

        public new static IfcPolyline FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPolyline>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Points != null ? Points.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}