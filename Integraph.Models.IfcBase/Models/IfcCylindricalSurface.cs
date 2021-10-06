using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccylindricalsurface.htm" />
	/// </summary>
	public class IfcCylindricalSurface : IfcElementarySurface
    {
	    /// <summary>
	    ///     Construct a IfcCylindricalSurface with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCylindricalSurface(IfcAxis2Placement3D position, IfcPositiveLengthMeasure radius) : base(position)
        {
            Radius = radius;
        }

        public IfcPositiveLengthMeasure Radius { get; set; }

        public new static IfcCylindricalSurface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCylindricalSurface>(json);
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