using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcgeometriccurveset.htm" />
	/// </summary>
	public class IfcGeometricCurveSet : IfcGeometricSet
    {
	    /// <summary>
	    ///     Construct a IfcGeometricCurveSet with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcGeometricCurveSet(List<IfcGeometricSetSelect> elements) : base(elements)
        {
        }

        public new static IfcGeometricCurveSet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcGeometricCurveSet>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Elements != null ? Elements.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}