using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcblock.htm" />
	/// </summary>
	public class IfcBlock : IfcCsgPrimitive3D
    {
	    /// <summary>
	    ///     Construct a IfcBlock with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBlock(IfcAxis2Placement3D position, IfcPositiveLengthMeasure xLength,
            IfcPositiveLengthMeasure yLength, IfcPositiveLengthMeasure zLength) : base(position)
        {
            XLength = xLength;
            YLength = yLength;
            ZLength = zLength;
        }

        public IfcPositiveLengthMeasure XLength { get; set; }
        public IfcPositiveLengthMeasure YLength { get; set; }
        public IfcPositiveLengthMeasure ZLength { get; set; }

        public new static IfcBlock FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBlock>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Position != null ? Position.ToStepValue() : "$",
                XLength != null ? XLength.ToStepValue() : "$",
                YLength != null ? YLength.ToStepValue() : "$",
                ZLength != null ? ZLength.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}