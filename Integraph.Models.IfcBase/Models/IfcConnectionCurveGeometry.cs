using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconnectioncurvegeometry.htm" />
	/// </summary>
	public class IfcConnectionCurveGeometry : IfcConnectionGeometry
    {
	    /// <summary>
	    ///     Construct a IfcConnectionCurveGeometry with all required attributes.
	    /// </summary>
	    public IfcConnectionCurveGeometry(IfcCurveOrEdgeCurve curveOnRelatingElement)
        {
            CurveOnRelatingElement = curveOnRelatingElement;
        }

	    /// <summary>
	    ///     Construct a IfcConnectionCurveGeometry with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConnectionCurveGeometry(IfcCurveOrEdgeCurve curveOnRelatingElement,
            IfcCurveOrEdgeCurve curveOnRelatedElement)
        {
            CurveOnRelatingElement = curveOnRelatingElement;
            CurveOnRelatedElement = curveOnRelatedElement;
        }

        public IfcCurveOrEdgeCurve CurveOnRelatingElement { get; set; }
        public IfcCurveOrEdgeCurve CurveOnRelatedElement { get; set; } // optional

        public new static IfcConnectionCurveGeometry FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConnectionCurveGeometry>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            CurveOnRelatingElement != null ? CurveOnRelatingElement.ToStepValue() : "$",
	            CurveOnRelatedElement != null ? CurveOnRelatedElement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}