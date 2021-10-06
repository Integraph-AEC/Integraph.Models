using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcvertexpoint.htm" />
	/// </summary>
	public class IfcVertexPoint : IfcVertex
    {
	    /// <summary>
	    ///     Construct a IfcVertexPoint with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcVertexPoint(IfcPoint vertexGeometry)
        {
            VertexGeometry = vertexGeometry;
        }

        public IfcPoint VertexGeometry { get; set; }

        public new static IfcVertexPoint FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcVertexPoint>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {VertexGeometry != null ? VertexGeometry.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}