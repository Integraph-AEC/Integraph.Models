using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfixedreferencesweptareasolid.htm" />
	/// </summary>
	public class IfcFixedReferenceSweptAreaSolid : IfcSweptAreaSolid
    {
	    /// <summary>
	    ///     Construct a IfcFixedReferenceSweptAreaSolid with all required attributes.
	    /// </summary>
	    public IfcFixedReferenceSweptAreaSolid(IfcProfileDef sweptArea, IfcCurve directrix, IfcDirection fixedReference)
            : base(sweptArea)
        {
            Directrix = directrix;
            FixedReference = fixedReference;
        }

	    /// <summary>
	    ///     Construct a IfcFixedReferenceSweptAreaSolid with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFixedReferenceSweptAreaSolid(IfcProfileDef sweptArea, IfcAxis2Placement3D position,
            IfcCurve directrix, IfcParameterValue startParam, IfcParameterValue endParam, IfcDirection fixedReference) :
            base(sweptArea, position)
        {
            Directrix = directrix;
            StartParam = startParam;
            EndParam = endParam;
            FixedReference = fixedReference;
        }

        public IfcCurve Directrix { get; set; }
        public IfcParameterValue StartParam { get; set; } // optional
        public IfcParameterValue EndParam { get; set; } // optional
        public IfcDirection FixedReference { get; set; }

        public new static IfcFixedReferenceSweptAreaSolid FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFixedReferenceSweptAreaSolid>(json);
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
                FixedReference != null ? FixedReference.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}