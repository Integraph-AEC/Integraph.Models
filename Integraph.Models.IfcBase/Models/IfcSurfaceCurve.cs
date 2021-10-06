using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfacecurve.htm" />
	/// </summary>
	public class IfcSurfaceCurve : IfcCurve
    {
	    /// <summary>
	    ///     Construct a IfcSurfaceCurve with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurfaceCurve(IfcCurve curve3D, List<IfcPcurve> associatedGeometry,
            IfcPreferredSurfaceCurveRepresentation masterRepresentation)
        {
            Curve3D = curve3D;
            AssociatedGeometry = associatedGeometry;
            MasterRepresentation = masterRepresentation;
        }

        public IfcCurve Curve3D { get; set; }
        public List<IfcPcurve> AssociatedGeometry { get; set; }
        public IfcPreferredSurfaceCurveRepresentation? MasterRepresentation { get; set; }

        [JsonIgnore]
        public List<IfcSurface> BasisSurface =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for BasisSurface."); // derived

        public new static IfcSurfaceCurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurfaceCurve>(json);
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