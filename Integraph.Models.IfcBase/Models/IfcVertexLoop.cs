using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcvertexloop.htm" />
	/// </summary>
	public class IfcVertexLoop : IfcLoop
    {
	    /// <summary>
	    ///     Construct a IfcVertexLoop with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcVertexLoop(IfcVertex loopVertex)
        {
            LoopVertex = loopVertex;
        }

        public IfcVertex LoopVertex { get; set; }

        public new static IfcVertexLoop FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcVertexLoop>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {LoopVertex != null ? LoopVertex.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}