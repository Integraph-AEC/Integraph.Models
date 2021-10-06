using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcedgeloop.htm" />
	/// </summary>
	public class IfcEdgeLoop : IfcLoop
    {
	    /// <summary>
	    ///     Construct a IfcEdgeLoop with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcEdgeLoop(List<IfcOrientedEdge> edgeList)
        {
            EdgeList = edgeList;
        }

        public List<IfcOrientedEdge> EdgeList { get; set; }

        [JsonIgnore]
        public IfcInteger Ne =>
            throw new NotImplementedException("Derived property logic has been implemented for Ne."); // derived

        public new static IfcEdgeLoop FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcEdgeLoop>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {EdgeList != null ? EdgeList.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}