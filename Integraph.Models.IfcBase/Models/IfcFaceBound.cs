using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfacebound.htm" />
	/// </summary>
	public class IfcFaceBound : IfcTopologicalRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcFaceBound with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFaceBound(IfcLoop bound, IfcBoolean orientation)
        {
            Bound = bound;
            Orientation = orientation;
        }

        public IfcLoop Bound { get; set; }
        public IfcBoolean Orientation { get; set; }

        public new static IfcFaceBound FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFaceBound>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Bound != null ? Bound.ToStepValue() : "$",
	            Orientation != null ? Orientation.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}