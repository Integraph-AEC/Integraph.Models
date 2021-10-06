using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsphere.htm" />
	/// </summary>
	public class IfcSphere : IfcCsgPrimitive3D
    {
	    /// <summary>
	    ///     Construct a IfcSphere with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSphere(IfcAxis2Placement3D position, IfcPositiveLengthMeasure radius) : base(position)
        {
            Radius = radius;
        }

        public IfcPositiveLengthMeasure Radius { get; set; }

        public new static IfcSphere FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSphere>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Position != null ? Position.ToStepValue() : "$",
	            Radius != null ? Radius.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}