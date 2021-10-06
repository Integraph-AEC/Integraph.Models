using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccircle.htm" />
	/// </summary>
	public class IfcCircle : IfcConic
    {
	    /// <summary>
	    ///     Construct a IfcCircle with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCircle(IfcAxis2Placement position, IfcPositiveLengthMeasure radius) : base(position)
        {
            Radius = radius;
        }

        public IfcPositiveLengthMeasure Radius { get; set; }

        public new static IfcCircle FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCircle>(json);
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