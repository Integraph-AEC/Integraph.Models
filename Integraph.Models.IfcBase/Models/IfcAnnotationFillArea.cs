using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcannotationfillarea.htm" />
	/// </summary>
	public class IfcAnnotationFillArea : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcAnnotationFillArea with all required attributes.
	    /// </summary>
	    public IfcAnnotationFillArea(IfcCurve outerBoundary)
        {
            InnerBoundaries = new List<IfcCurve>();

            OuterBoundary = outerBoundary;
        }

	    /// <summary>
	    ///     Construct a IfcAnnotationFillArea with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcAnnotationFillArea(IfcCurve outerBoundary, List<IfcCurve> innerBoundaries)
        {
            OuterBoundary = outerBoundary;
            InnerBoundaries = innerBoundaries;
        }

        public IfcCurve OuterBoundary { get; set; }
        public List<IfcCurve> InnerBoundaries { get; set; } // optional

        public new static IfcAnnotationFillArea FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAnnotationFillArea>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            OuterBoundary != null ? OuterBoundary.ToStepValue() : "$",
	            InnerBoundaries != null ? InnerBoundaries.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}