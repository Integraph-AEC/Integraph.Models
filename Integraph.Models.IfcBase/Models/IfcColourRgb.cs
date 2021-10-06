using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccolourrgb.htm" />
	/// </summary>
	public class IfcColourRgb : IfcColourSpecification
    {
	    /// <summary>
	    ///     Construct a IfcColourRgb with all required attributes.
	    /// </summary>
	    public IfcColourRgb(IfcNormalisedRatioMeasure red, IfcNormalisedRatioMeasure green,
            IfcNormalisedRatioMeasure blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

	    /// <summary>
	    ///     Construct a IfcColourRgb with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcColourRgb(IfcLabel name, IfcNormalisedRatioMeasure red, IfcNormalisedRatioMeasure green,
            IfcNormalisedRatioMeasure blue) : base(name)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public IfcNormalisedRatioMeasure Red { get; set; }
        public IfcNormalisedRatioMeasure Green { get; set; }
        public IfcNormalisedRatioMeasure Blue { get; set; }

        public new static IfcColourRgb FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcColourRgb>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Red != null ? Red.ToStepValue() : "$",
                Green != null ? Green.ToStepValue() : "$",
                Blue != null ? Blue.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}