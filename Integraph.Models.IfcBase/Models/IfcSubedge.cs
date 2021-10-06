using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsubedge.htm" />
	/// </summary>
	public class IfcSubedge : IfcEdge
    {
	    /// <summary>
	    ///     Construct a IfcSubedge with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSubedge(IfcVertex edgeStart, IfcVertex edgeEnd, IfcEdge parentEdge) : base(edgeStart, edgeEnd)
        {
            ParentEdge = parentEdge;
        }

        public IfcEdge ParentEdge { get; set; }

        public new static IfcSubedge FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSubedge>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            EdgeStart != null ? EdgeStart.ToStepValue() : "$",
	            EdgeEnd != null ? EdgeEnd.ToStepValue() : "$",
	            ParentEdge != null ? ParentEdge.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}