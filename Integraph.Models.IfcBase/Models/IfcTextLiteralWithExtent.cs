using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctextliteralwithextent.htm" />
	/// </summary>
	public class IfcTextLiteralWithExtent : IfcTextLiteral
    {
	    /// <summary>
	    ///     Construct a IfcTextLiteralWithExtent with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTextLiteralWithExtent(IfcPresentableText literal, IfcAxis2Placement placement, IfcTextPath path,
            IfcPlanarExtent extent, IfcBoxAlignment boxAlignment) : base(literal, placement, path)
        {
            Extent = extent;
            BoxAlignment = boxAlignment;
        }

        public IfcPlanarExtent Extent { get; set; }
        public IfcBoxAlignment BoxAlignment { get; set; }

        public new static IfcTextLiteralWithExtent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextLiteralWithExtent>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Literal != null ? Literal.ToStepValue() : "$",
                Placement != null ? Placement.ToStepValue() : "$",
                Path != null ? Path.ToStepValue() : "$",
                Extent != null ? Extent.ToStepValue() : "$",
                BoxAlignment != null ? BoxAlignment.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}