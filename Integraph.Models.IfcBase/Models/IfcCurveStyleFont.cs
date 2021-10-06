using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccurvestylefont.htm" />
	/// </summary>
	public class IfcCurveStyleFont : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcCurveStyleFont with all required attributes.
	    /// </summary>
	    public IfcCurveStyleFont(List<IfcCurveStyleFontPattern> patternList)
        {
            PatternList = patternList;
        }

	    /// <summary>
	    ///     Construct a IfcCurveStyleFont with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCurveStyleFont(IfcLabel name, List<IfcCurveStyleFontPattern> patternList)
        {
            Name = name;
            PatternList = patternList;
        }

        public IfcLabel Name { get; set; } // optional
        public List<IfcCurveStyleFontPattern> PatternList { get; set; }

        public new static IfcCurveStyleFont FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCurveStyleFont>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            PatternList != null ? PatternList.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}