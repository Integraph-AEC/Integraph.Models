using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccurvestyle.htm" />
	/// </summary>
	public class IfcCurveStyle : IfcPresentationStyle
    {
	    /// <summary>
	    ///     Construct a IfcCurveStyle with all required attributes.
	    /// </summary>
	    public IfcCurveStyle()
        {
        }

	    /// <summary>
	    ///     Construct a IfcCurveStyle with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCurveStyle(IfcLabel name, IfcCurveFontOrScaledCurveFontSelect curveFont, IfcSizeSelect curveWidth,
            IfcColour curveColour, IfcBoolean modelOrDraughting) : base(name)
        {
            CurveFont = curveFont;
            CurveWidth = curveWidth;
            CurveColour = curveColour;
            ModelOrDraughting = modelOrDraughting;
        }

        public IfcCurveFontOrScaledCurveFontSelect CurveFont { get; set; } // optional
        public IfcSizeSelect CurveWidth { get; set; } // optional
        public IfcColour CurveColour { get; set; } // optional
        public IfcBoolean ModelOrDraughting { get; set; } // optional

        public new static IfcCurveStyle FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCurveStyle>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            CurveFont != null ? CurveFont.ToStepValue() : "$",
	            CurveWidth != null ? CurveWidth.ToStepValue() : "$",
	            CurveColour != null ? CurveColour.ToStepValue() : "$",
	            ModelOrDraughting != null ? ModelOrDraughting.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}