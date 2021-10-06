using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccurvestylefontpattern.htm" />
	/// </summary>
	public class IfcCurveStyleFontPattern : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcCurveStyleFontPattern with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCurveStyleFontPattern(IfcLengthMeasure visibleSegmentLength,
            IfcPositiveLengthMeasure invisibleSegmentLength)
        {
            VisibleSegmentLength = visibleSegmentLength;
            InvisibleSegmentLength = invisibleSegmentLength;
        }

        public IfcLengthMeasure VisibleSegmentLength { get; set; }
        public IfcPositiveLengthMeasure InvisibleSegmentLength { get; set; }

        public new static IfcCurveStyleFontPattern FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCurveStyleFontPattern>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                VisibleSegmentLength != null ? VisibleSegmentLength.ToStepValue() : "$",
                InvisibleSegmentLength != null ? InvisibleSegmentLength.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}