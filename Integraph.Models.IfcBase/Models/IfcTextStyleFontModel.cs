using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctextstylefontmodel.htm" />
	/// </summary>
	public class IfcTextStyleFontModel : IfcPreDefinedTextFont
    {
	    /// <summary>
	    ///     Construct a IfcTextStyleFontModel with all required attributes.
	    /// </summary>
	    public IfcTextStyleFontModel(IfcLabel name, List<IfcTextFontName> fontFamily, IfcSizeSelect fontSize) :
            base(name)
        {
            FontFamily = fontFamily;
            FontSize = fontSize;
        }

	    /// <summary>
	    ///     Construct a IfcTextStyleFontModel with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTextStyleFontModel(IfcLabel name, List<IfcTextFontName> fontFamily, IfcFontStyle fontStyle,
            IfcFontVariant fontVariant, IfcFontWeight fontWeight, IfcSizeSelect fontSize) : base(name)
        {
            FontFamily = fontFamily;
            FontStyle = fontStyle;
            FontVariant = fontVariant;
            FontWeight = fontWeight;
            FontSize = fontSize;
        }

        public List<IfcTextFontName> FontFamily { get; set; }
        public IfcFontStyle FontStyle { get; set; } // optional
        public IfcFontVariant FontVariant { get; set; } // optional
        public IfcFontWeight FontWeight { get; set; } // optional
        public IfcSizeSelect FontSize { get; set; }

        public new static IfcTextStyleFontModel FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextStyleFontModel>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                FontFamily != null ? FontFamily.ToStepValue() : "$",
                FontStyle != null ? FontStyle.ToStepValue() : "$",
                FontVariant != null ? FontVariant.ToStepValue() : "$",
                FontWeight != null ? FontWeight.ToStepValue() : "$",
                FontSize != null ? FontSize.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}