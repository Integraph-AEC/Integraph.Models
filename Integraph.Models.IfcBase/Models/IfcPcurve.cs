using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpcurve.htm" />
	/// </summary>
	public class IfcPcurve : IfcCurve
    {
	    /// <summary>
	    ///     Construct a IfcPcurve with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPcurve(IfcSurface basisSurface, IfcCurve referenceCurve)
        {
            BasisSurface = basisSurface;
            ReferenceCurve = referenceCurve;
        }

        public IfcSurface BasisSurface { get; set; }
        public IfcCurve ReferenceCurve { get; set; }

        public new static IfcPcurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPcurve>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            BasisSurface != null ? BasisSurface.ToStepValue() : "$",
	            ReferenceCurve != null ? ReferenceCurve.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}