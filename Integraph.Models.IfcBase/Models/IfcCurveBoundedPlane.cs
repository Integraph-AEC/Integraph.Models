using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccurveboundedplane.htm" />
	/// </summary>
	public class IfcCurveBoundedPlane : IfcBoundedSurface
    {
	    /// <summary>
	    ///     Construct a IfcCurveBoundedPlane with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCurveBoundedPlane(IfcPlane basisSurface, IfcCurve outerBoundary, List<IfcCurve> innerBoundaries)
        {
            BasisSurface = basisSurface;
            OuterBoundary = outerBoundary;
            InnerBoundaries = innerBoundaries;
        }

        public IfcPlane BasisSurface { get; set; }
        public IfcCurve OuterBoundary { get; set; }
        public List<IfcCurve> InnerBoundaries { get; set; }

        public new static IfcCurveBoundedPlane FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCurveBoundedPlane>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            BasisSurface != null ? BasisSurface.ToStepValue() : "$",
	            OuterBoundary != null ? OuterBoundary.ToStepValue() : "$",
	            InnerBoundaries != null ? InnerBoundaries.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}