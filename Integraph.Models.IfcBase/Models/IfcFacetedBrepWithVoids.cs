using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfacetedbrepwithvoids.htm" />
	/// </summary>
	public class IfcFacetedBrepWithVoids : IfcFacetedBrep
    {
	    /// <summary>
	    ///     Construct a IfcFacetedBrepWithVoids with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFacetedBrepWithVoids(IfcClosedShell outer, List<IfcClosedShell> voids) : base(outer)
        {
            Voids = voids;
        }

        public List<IfcClosedShell> Voids { get; set; }

        public new static IfcFacetedBrepWithVoids FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFacetedBrepWithVoids>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Outer != null ? Outer.ToStepValue() : "$",
	            Voids != null ? Voids.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}