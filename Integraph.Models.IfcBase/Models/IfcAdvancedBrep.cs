using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcadvancedbrep.htm" />
	/// </summary>
	public class IfcAdvancedBrep : IfcManifoldSolidBrep
    {
	    /// <summary>
	    ///     Construct a IfcAdvancedBrep with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcAdvancedBrep(IfcClosedShell outer) : base(outer)
        {
        }

        public new static IfcAdvancedBrep FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAdvancedBrep>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Outer != null ? Outer.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}