using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconnectionpointeccentricity.htm" />
	/// </summary>
	public class IfcConnectionPointEccentricity : IfcConnectionPointGeometry
    {
	    /// <summary>
	    ///     Construct a IfcConnectionPointEccentricity with all required attributes.
	    /// </summary>
	    public IfcConnectionPointEccentricity(IfcPointOrVertexPoint pointOnRelatingElement) : base(
            pointOnRelatingElement)
        {
        }

	    /// <summary>
	    ///     Construct a IfcConnectionPointEccentricity with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConnectionPointEccentricity(IfcPointOrVertexPoint pointOnRelatingElement,
            IfcPointOrVertexPoint pointOnRelatedElement, IfcLengthMeasure eccentricityInX,
            IfcLengthMeasure eccentricityInY, IfcLengthMeasure eccentricityInZ) : base(pointOnRelatingElement,
            pointOnRelatedElement)
        {
            EccentricityInX = eccentricityInX;
            EccentricityInY = eccentricityInY;
            EccentricityInZ = eccentricityInZ;
        }

        public IfcLengthMeasure EccentricityInX { get; set; } // optional
        public IfcLengthMeasure EccentricityInY { get; set; } // optional
        public IfcLengthMeasure EccentricityInZ { get; set; } // optional

        public new static IfcConnectionPointEccentricity FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConnectionPointEccentricity>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            PointOnRelatingElement != null ? PointOnRelatingElement.ToStepValue() : "$",
	            PointOnRelatedElement != null ? PointOnRelatedElement.ToStepValue() : "$",
	            EccentricityInX != null ? EccentricityInX.ToStepValue() : "$",
	            EccentricityInY != null ? EccentricityInY.ToStepValue() : "$",
	            EccentricityInZ != null ? EccentricityInZ.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}