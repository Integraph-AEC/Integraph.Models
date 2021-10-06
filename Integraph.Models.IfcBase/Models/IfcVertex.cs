using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcvertex.htm" />
	/// </summary>
	public class IfcVertex : IfcTopologicalRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcVertex with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcVertex()
        {
        }

        public new static IfcVertex FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcVertex>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>();

            return string.Join(", ", parameters.ToArray());
        }
    }
}