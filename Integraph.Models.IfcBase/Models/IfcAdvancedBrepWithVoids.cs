using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcadvancedbrepwithvoids.htm" />
	/// </summary>
	public class IfcAdvancedBrepWithVoids : IfcAdvancedBrep
    {
	    /// <summary>
	    ///     Construct a IfcAdvancedBrepWithVoids with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcAdvancedBrepWithVoids(IfcClosedShell outer, List<IfcClosedShell> voids) : base(outer)
        {
            Voids = voids;
        }

        public List<IfcClosedShell> Voids { get; set; }

        public new static IfcAdvancedBrepWithVoids FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAdvancedBrepWithVoids>(json);
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