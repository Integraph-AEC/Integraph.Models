using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcintersectioncurve.htm" />
	/// </summary>
	public class IfcIntersectionCurve : IfcSurfaceCurve
    {
	    /// <summary>
	    ///     Construct a IfcIntersectionCurve with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcIntersectionCurve(IfcCurve curve3D, List<IfcPcurve> associatedGeometry,
            IfcPreferredSurfaceCurveRepresentation masterRepresentation) : base(curve3D, associatedGeometry,
            masterRepresentation)
        {
        }

        public new static IfcIntersectionCurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIntersectionCurve>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Curve3D != null ? Curve3D.ToStepValue() : "$",
	            AssociatedGeometry != null ? AssociatedGeometry.ToStepValue() : "$",
	            MasterRepresentation != null ? MasterRepresentation.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}