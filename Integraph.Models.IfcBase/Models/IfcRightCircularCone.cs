using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrightcircularcone.htm" />
	/// </summary>
	public class IfcRightCircularCone : IfcCsgPrimitive3D
    {
	    /// <summary>
	    ///     Construct a IfcRightCircularCone with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRightCircularCone(IfcAxis2Placement3D position, IfcPositiveLengthMeasure height,
            IfcPositiveLengthMeasure bottomRadius) : base(position)
        {
            Height = height;
            BottomRadius = bottomRadius;
        }

        public IfcPositiveLengthMeasure Height { get; set; }
        public IfcPositiveLengthMeasure BottomRadius { get; set; }

        public new static IfcRightCircularCone FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRightCircularCone>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Position != null ? Position.ToStepValue() : "$",
                Height != null ? Height.ToStepValue() : "$",
                BottomRadius != null ? BottomRadius.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}