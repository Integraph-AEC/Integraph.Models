using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcorientededge.htm" />
	/// </summary>
	public class IfcOrientedEdge : IfcEdge
    {
	    /// <summary>
	    ///     Construct a IfcOrientedEdge with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcOrientedEdge(IfcVertex edgeStart, IfcVertex edgeEnd, IfcEdge edgeElement, IfcBoolean orientation) :
            base(edgeStart, edgeEnd)
        {
            EdgeElement = edgeElement;
            Orientation = orientation;
        }

        public IfcEdge EdgeElement { get; set; }
        public IfcBoolean Orientation { get; set; }

        [JsonIgnore]
        public new IfcVertex EdgeStart =>
            throw new NotImplementedException("Derived property logic has been implemented for EdgeStart."); // derived

        [JsonIgnore]
        public new IfcVertex EdgeEnd =>
            throw new NotImplementedException("Derived property logic has been implemented for EdgeEnd."); // derived

        public new static IfcOrientedEdge FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcOrientedEdge>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                "*",
                "*",
                EdgeElement != null ? EdgeElement.ToStepValue() : "$",
                Orientation != null ? Orientation.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}