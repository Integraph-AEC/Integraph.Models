using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcoffsetcurve3d.htm" />
	/// </summary>
	public class IfcOffsetCurve3D : IfcCurve
    {
	    /// <summary>
	    ///     Construct a IfcOffsetCurve3D with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcOffsetCurve3D(IfcCurve basisCurve, IfcLengthMeasure distance, IfcLogical selfIntersect,
            IfcDirection refDirection)
        {
            BasisCurve = basisCurve;
            Distance = distance;
            SelfIntersect = selfIntersect;
            RefDirection = refDirection;
        }

        public IfcCurve BasisCurve { get; set; }
        public IfcLengthMeasure Distance { get; set; }
        public IfcLogical SelfIntersect { get; set; }
        public IfcDirection RefDirection { get; set; }

        public new static IfcOffsetCurve3D FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcOffsetCurve3D>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                BasisCurve != null ? BasisCurve.ToStepValue() : "$",
                Distance != null ? Distance.ToStepValue() : "$",
                SelfIntersect != null ? SelfIntersect.ToStepValue() : "$",
                RefDirection != null ? RefDirection.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}