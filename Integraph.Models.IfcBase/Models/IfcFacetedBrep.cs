using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfacetedbrep.htm" />
	/// </summary>
	public class IfcFacetedBrep : IfcManifoldSolidBrep
    {
	    /// <summary>
	    ///     Construct a IfcFacetedBrep with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFacetedBrep(IfcClosedShell outer) : base(outer)
        {
        }

        public new static IfcFacetedBrep FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFacetedBrep>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Outer != null ? Outer.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}