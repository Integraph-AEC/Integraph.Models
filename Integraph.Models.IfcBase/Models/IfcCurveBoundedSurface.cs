using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccurveboundedsurface.htm" />
	/// </summary>
	public class IfcCurveBoundedSurface : IfcBoundedSurface
    {
	    /// <summary>
	    ///     Construct a IfcCurveBoundedSurface with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCurveBoundedSurface(IfcSurface basisSurface, List<IfcBoundaryCurve> boundaries,
            IfcBoolean implicitOuter)
        {
            BasisSurface = basisSurface;
            Boundaries = boundaries;
            ImplicitOuter = implicitOuter;
        }

        public IfcSurface BasisSurface { get; set; }
        public List<IfcBoundaryCurve> Boundaries { get; set; }
        public IfcBoolean ImplicitOuter { get; set; }

        public new static IfcCurveBoundedSurface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCurveBoundedSurface>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                BasisSurface != null ? BasisSurface.ToStepValue() : "$",
                Boundaries != null ? Boundaries.ToStepValue() : "$",
                ImplicitOuter != null ? ImplicitOuter.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}