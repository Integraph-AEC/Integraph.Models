using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcvirtualgridintersection.htm" />
	/// </summary>
	public class IfcVirtualGridIntersection : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcVirtualGridIntersection with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcVirtualGridIntersection(List<IfcGridAxis> intersectingAxes, List<IfcLengthMeasure> offsetDistances)
        {
            IntersectingAxes = intersectingAxes;
            OffsetDistances = offsetDistances;
        }

        public List<IfcGridAxis> IntersectingAxes { get; set; }
        public List<IfcLengthMeasure> OffsetDistances { get; set; }

        public static IfcVirtualGridIntersection FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcVirtualGridIntersection>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            IntersectingAxes != null ? IntersectingAxes.ToStepValue() : "$",
	            OffsetDistances != null ? OffsetDistances.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}