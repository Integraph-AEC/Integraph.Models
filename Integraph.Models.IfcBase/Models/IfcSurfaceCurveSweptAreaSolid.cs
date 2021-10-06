using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfacecurvesweptareasolid.htm" />
	/// </summary>
	public class IfcSurfaceCurveSweptAreaSolid : IfcSweptAreaSolid
    {
	    /// <summary>
	    ///     Construct a IfcSurfaceCurveSweptAreaSolid with all required attributes.
	    /// </summary>
	    public IfcSurfaceCurveSweptAreaSolid(IfcProfileDef sweptArea, IfcCurve directrix, IfcSurface referenceSurface) :
            base(sweptArea)
        {
            Directrix = directrix;
            ReferenceSurface = referenceSurface;
        }

	    /// <summary>
	    ///     Construct a IfcSurfaceCurveSweptAreaSolid with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurfaceCurveSweptAreaSolid(IfcProfileDef sweptArea, IfcAxis2Placement3D position, IfcCurve directrix,
            IfcParameterValue startParam, IfcParameterValue endParam, IfcSurface referenceSurface) : base(sweptArea,
            position)
        {
            Directrix = directrix;
            StartParam = startParam;
            EndParam = endParam;
            ReferenceSurface = referenceSurface;
        }

        public IfcCurve Directrix { get; set; }
        public IfcParameterValue StartParam { get; set; } // optional
        public IfcParameterValue EndParam { get; set; } // optional
        public IfcSurface ReferenceSurface { get; set; }

        public new static IfcSurfaceCurveSweptAreaSolid FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurfaceCurveSweptAreaSolid>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                SweptArea != null ? SweptArea.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                Directrix != null ? Directrix.ToStepValue() : "$",
                StartParam != null ? StartParam.ToStepValue() : "$",
                EndParam != null ? EndParam.ToStepValue() : "$",
                ReferenceSurface != null ? ReferenceSurface.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}