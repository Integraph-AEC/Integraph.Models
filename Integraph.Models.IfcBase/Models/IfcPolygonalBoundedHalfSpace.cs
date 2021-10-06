using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpolygonalboundedhalfspace.htm" />
	/// </summary>
	public class IfcPolygonalBoundedHalfSpace : IfcHalfSpaceSolid
    {
	    /// <summary>
	    ///     Construct a IfcPolygonalBoundedHalfSpace with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPolygonalBoundedHalfSpace(IfcSurface baseSurface, IfcBoolean agreementFlag,
            IfcAxis2Placement3D position, IfcBoundedCurve polygonalBoundary) : base(baseSurface, agreementFlag)
        {
            Position = position;
            PolygonalBoundary = polygonalBoundary;
        }

        public IfcAxis2Placement3D Position { get; set; }
        public IfcBoundedCurve PolygonalBoundary { get; set; }

        public new static IfcPolygonalBoundedHalfSpace FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPolygonalBoundedHalfSpace>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                BaseSurface != null ? BaseSurface.ToStepValue() : "$",
                AgreementFlag != null ? AgreementFlag.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                PolygonalBoundary != null ? PolygonalBoundary.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}