using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccurvestylefontandscaling.htm" />
	/// </summary>
	public class IfcCurveStyleFontAndScaling : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcCurveStyleFontAndScaling with all required attributes.
	    /// </summary>
	    public IfcCurveStyleFontAndScaling(IfcCurveStyleFontSelect curveFont, IfcPositiveRatioMeasure curveFontScaling)
        {
            CurveFont = curveFont;
            CurveFontScaling = curveFontScaling;
        }

	    /// <summary>
	    ///     Construct a IfcCurveStyleFontAndScaling with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCurveStyleFontAndScaling(IfcLabel name, IfcCurveStyleFontSelect curveFont,
            IfcPositiveRatioMeasure curveFontScaling)
        {
            Name = name;
            CurveFont = curveFont;
            CurveFontScaling = curveFontScaling;
        }

        public IfcLabel Name { get; set; } // optional
        public IfcCurveStyleFontSelect CurveFont { get; set; }
        public IfcPositiveRatioMeasure CurveFontScaling { get; set; }

        public new static IfcCurveStyleFontAndScaling FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCurveStyleFontAndScaling>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            CurveFont != null ? CurveFont.ToStepValue() : "$",
	            CurveFontScaling != null ? CurveFontScaling.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}