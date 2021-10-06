using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpath.htm" />
	/// </summary>
	public class IfcPath : IfcTopologicalRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcPath with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPath(List<IfcOrientedEdge> edgeList)
        {
            EdgeList = edgeList;
        }

        public List<IfcOrientedEdge> EdgeList { get; set; }

        public new static IfcPath FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPath>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {EdgeList != null ? EdgeList.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}