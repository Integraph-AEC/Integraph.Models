using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctextstyle.htm" />
	/// </summary>
	public class IfcTextStyle : IfcPresentationStyle
    {
	    /// <summary>
	    ///     Construct a IfcTextStyle with all required attributes.
	    /// </summary>
	    public IfcTextStyle(IfcTextFontSelect textFontStyle)
        {
            TextFontStyle = textFontStyle;
        }

	    /// <summary>
	    ///     Construct a IfcTextStyle with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTextStyle(IfcLabel name, IfcTextStyleForDefinedFont textCharacterAppearance,
            IfcTextStyleTextModel textStyle, IfcTextFontSelect textFontStyle, IfcBoolean modelOrDraughting) : base(name)
        {
            TextCharacterAppearance = textCharacterAppearance;
            TextStyle = textStyle;
            TextFontStyle = textFontStyle;
            ModelOrDraughting = modelOrDraughting;
        }

        public IfcTextStyleForDefinedFont TextCharacterAppearance { get; set; } // optional
        public IfcTextStyleTextModel TextStyle { get; set; } // optional
        public IfcTextFontSelect TextFontStyle { get; set; }
        public IfcBoolean ModelOrDraughting { get; set; } // optional

        public new static IfcTextStyle FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextStyle>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            TextCharacterAppearance != null ? TextCharacterAppearance.ToStepValue() : "$",
	            TextStyle != null ? TextStyle.ToStepValue() : "$",
	            TextFontStyle != null ? TextFontStyle.ToStepValue() : "$",
	            ModelOrDraughting != null ? ModelOrDraughting.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}