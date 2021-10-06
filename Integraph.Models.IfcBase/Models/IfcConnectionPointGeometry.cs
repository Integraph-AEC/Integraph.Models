using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconnectionpointgeometry.htm" />
	/// </summary>
	public class IfcConnectionPointGeometry : IfcConnectionGeometry
    {
	    /// <summary>
	    ///     Construct a IfcConnectionPointGeometry with all required attributes.
	    /// </summary>
	    public IfcConnectionPointGeometry(IfcPointOrVertexPoint pointOnRelatingElement)
        {
            PointOnRelatingElement = pointOnRelatingElement;
        }

	    /// <summary>
	    ///     Construct a IfcConnectionPointGeometry with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConnectionPointGeometry(IfcPointOrVertexPoint pointOnRelatingElement,
            IfcPointOrVertexPoint pointOnRelatedElement)
        {
            PointOnRelatingElement = pointOnRelatingElement;
            PointOnRelatedElement = pointOnRelatedElement;
        }

        public IfcPointOrVertexPoint PointOnRelatingElement { get; set; }
        public IfcPointOrVertexPoint PointOnRelatedElement { get; set; } // optional

        public new static IfcConnectionPointGeometry FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConnectionPointGeometry>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            PointOnRelatingElement != null ? PointOnRelatingElement.ToStepValue() : "$",
	            PointOnRelatedElement != null ? PointOnRelatedElement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}