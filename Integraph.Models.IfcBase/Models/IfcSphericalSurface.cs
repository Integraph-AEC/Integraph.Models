using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsphericalsurface.htm" />
	/// </summary>
	public class IfcSphericalSurface : IfcElementarySurface
    {
	    /// <summary>
	    ///     Construct a IfcSphericalSurface with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSphericalSurface(IfcAxis2Placement3D position, IfcPositiveLengthMeasure radius) : base(position)
        {
            Radius = radius;
        }

        public IfcPositiveLengthMeasure Radius { get; set; }

        public new static IfcSphericalSurface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSphericalSurface>(json);
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