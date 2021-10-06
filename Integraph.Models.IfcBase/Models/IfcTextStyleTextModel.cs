using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctextstyletextmodel.htm" />
	/// </summary>
	public class IfcTextStyleTextModel : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcTextStyleTextModel with all required attributes.
	    /// </summary>
	    public IfcTextStyleTextModel()
        {
        }

	    /// <summary>
	    ///     Construct a IfcTextStyleTextModel with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTextStyleTextModel(IfcSizeSelect textIndent, IfcTextAlignment textAlign,
            IfcTextDecoration textDecoration, IfcSizeSelect letterSpacing, IfcSizeSelect wordSpacing,
            IfcTextTransformation textTransform, IfcSizeSelect lineHeight)
        {
            TextIndent = textIndent;
            TextAlign = textAlign;
            TextDecoration = textDecoration;
            LetterSpacing = letterSpacing;
            WordSpacing = wordSpacing;
            TextTransform = textTransform;
            LineHeight = lineHeight;
        }

        public IfcSizeSelect TextIndent { get; set; } // optional
        public IfcTextAlignment TextAlign { get; set; } // optional
        public IfcTextDecoration TextDecoration { get; set; } // optional
        public IfcSizeSelect LetterSpacing { get; set; } // optional
        public IfcSizeSelect WordSpacing { get; set; } // optional
        public IfcTextTransformation TextTransform { get; set; } // optional
        public IfcSizeSelect LineHeight { get; set; } // optional

        public new static IfcTextStyleTextModel FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextStyleTextModel>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            TextIndent != null ? TextIndent.ToStepValue() : "$",
	            TextAlign != null ? TextAlign.ToStepValue() : "$",
	            TextDecoration != null ? TextDecoration.ToStepValue() : "$",
	            LetterSpacing != null ? LetterSpacing.ToStepValue() : "$",
	            WordSpacing != null ? WordSpacing.ToStepValue() : "$",
	            TextTransform != null ? TextTransform.ToStepValue() : "$",
	            LineHeight != null ? LineHeight.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}