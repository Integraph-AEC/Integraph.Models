using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcedge.htm" />
	/// </summary>
	public class IfcEdge : IfcTopologicalRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcEdge with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcEdge(IfcVertex edgeStart, IfcVertex edgeEnd)
        {
            EdgeStart = edgeStart;
            EdgeEnd = edgeEnd;
        }

        public IfcVertex EdgeStart { get; set; }
        public IfcVertex EdgeEnd { get; set; }

        public new static IfcEdge FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcEdge>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            EdgeStart != null ? EdgeStart.ToStepValue() : "$",
	            EdgeEnd != null ? EdgeEnd.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}