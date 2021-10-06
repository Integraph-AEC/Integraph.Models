using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcloop.htm" />
	/// </summary>
	public class IfcLoop : IfcTopologicalRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcLoop with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLoop()
        {
        }

        public new static IfcLoop FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLoop>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>();

            return string.Join(", ", parameters.ToArray());
        }
    }
}