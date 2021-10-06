using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctextstylefordefinedfont.htm" />
	/// </summary>
	public class IfcTextStyleForDefinedFont : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcTextStyleForDefinedFont with all required attributes.
	    /// </summary>
	    public IfcTextStyleForDefinedFont(IfcColour colour)
        {
            Colour = colour;
        }

	    /// <summary>
	    ///     Construct a IfcTextStyleForDefinedFont with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTextStyleForDefinedFont(IfcColour colour, IfcColour backgroundColour)
        {
            Colour = colour;
            BackgroundColour = backgroundColour;
        }

        public IfcColour Colour { get; set; }
        public IfcColour BackgroundColour { get; set; } // optional

        public new static IfcTextStyleForDefinedFont FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextStyleForDefinedFont>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Colour != null ? Colour.ToStepValue() : "$",
	            BackgroundColour != null ? BackgroundColour.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}