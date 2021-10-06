using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcseamcurve.htm" />
	/// </summary>
	public class IfcSeamCurve : IfcSurfaceCurve
    {
	    /// <summary>
	    ///     Construct a IfcSeamCurve with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSeamCurve(IfcCurve curve3D, List<IfcPcurve> associatedGeometry,
            IfcPreferredSurfaceCurveRepresentation masterRepresentation) : base(curve3D, associatedGeometry,
            masterRepresentation)
        {
        }

        public new static IfcSeamCurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSeamCurve>(json);
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