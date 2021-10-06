using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcline.htm" />
	/// </summary>
	public class IfcLine : IfcCurve
    {
	    /// <summary>
	    ///     Construct a IfcLine with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLine(IfcCartesianPoint pnt, IfcVector dir)
        {
            Pnt = pnt;
            Dir = dir;
        }

        public IfcCartesianPoint Pnt { get; set; }
        public IfcVector Dir { get; set; }

        public new static IfcLine FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLine>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Pnt != null ? Pnt.ToStepValue() : "$",
	            Dir != null ? Dir.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}