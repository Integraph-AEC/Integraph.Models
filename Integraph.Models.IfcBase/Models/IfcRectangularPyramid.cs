using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrectangularpyramid.htm" />
	/// </summary>
	public class IfcRectangularPyramid : IfcCsgPrimitive3D
    {
	    /// <summary>
	    ///     Construct a IfcRectangularPyramid with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRectangularPyramid(IfcAxis2Placement3D position, IfcPositiveLengthMeasure xLength,
            IfcPositiveLengthMeasure yLength, IfcPositiveLengthMeasure height) : base(position)
        {
            XLength = xLength;
            YLength = yLength;
            Height = height;
        }

        public IfcPositiveLengthMeasure XLength { get; set; }
        public IfcPositiveLengthMeasure YLength { get; set; }
        public IfcPositiveLengthMeasure Height { get; set; }

        public new static IfcRectangularPyramid FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRectangularPyramid>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Position != null ? Position.ToStepValue() : "$",
                XLength != null ? XLength.ToStepValue() : "$",
                YLength != null ? YLength.ToStepValue() : "$",
                Height != null ? Height.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}