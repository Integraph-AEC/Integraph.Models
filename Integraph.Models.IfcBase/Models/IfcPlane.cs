using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcplane.htm" />
	/// </summary>
	public class IfcPlane : IfcElementarySurface
    {
	    /// <summary>
	    ///     Construct a IfcPlane with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPlane(IfcAxis2Placement3D position) : base(position)
        {
        }

        public new static IfcPlane FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPlane>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Position != null ? Position.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}