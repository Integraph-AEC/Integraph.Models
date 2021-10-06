using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctextliteral.htm" />
	/// </summary>
	public class IfcTextLiteral : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcTextLiteral with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTextLiteral(IfcPresentableText literal, IfcAxis2Placement placement, IfcTextPath path)
        {
            Literal = literal;
            Placement = placement;
            Path = path;
        }

        public IfcPresentableText Literal { get; set; }
        public IfcAxis2Placement Placement { get; set; }
        public IfcTextPath? Path { get; set; }

        public new static IfcTextLiteral FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextLiteral>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Literal != null ? Literal.ToStepValue() : "$",
	            Placement != null ? Placement.ToStepValue() : "$",
	            Path != null ? Path.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}