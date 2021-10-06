using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrightcircularcylinder.htm" />
	/// </summary>
	public class IfcRightCircularCylinder : IfcCsgPrimitive3D
    {
	    /// <summary>
	    ///     Construct a IfcRightCircularCylinder with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRightCircularCylinder(IfcAxis2Placement3D position, IfcPositiveLengthMeasure height,
            IfcPositiveLengthMeasure radius) : base(position)
        {
            Height = height;
            Radius = radius;
        }

        public IfcPositiveLengthMeasure Height { get; set; }
        public IfcPositiveLengthMeasure Radius { get; set; }

        public new static IfcRightCircularCylinder FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRightCircularCylinder>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Position != null ? Position.ToStepValue() : "$",
                Height != null ? Height.ToStepValue() : "$",
                Radius != null ? Radius.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}