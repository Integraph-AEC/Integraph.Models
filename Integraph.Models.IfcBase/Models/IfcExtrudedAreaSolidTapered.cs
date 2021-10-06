using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcextrudedareasolidtapered.htm" />
	/// </summary>
	public class IfcExtrudedAreaSolidTapered : IfcExtrudedAreaSolid
    {
	    /// <summary>
	    ///     Construct a IfcExtrudedAreaSolidTapered with all required attributes.
	    /// </summary>
	    public IfcExtrudedAreaSolidTapered(IfcProfileDef sweptArea, IfcDirection extrudedDirection,
            IfcPositiveLengthMeasure depth, IfcProfileDef endSweptArea) : base(sweptArea, extrudedDirection, depth)
        {
            EndSweptArea = endSweptArea;
        }

	    /// <summary>
	    ///     Construct a IfcExtrudedAreaSolidTapered with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcExtrudedAreaSolidTapered(IfcProfileDef sweptArea, IfcAxis2Placement3D position,
            IfcDirection extrudedDirection, IfcPositiveLengthMeasure depth, IfcProfileDef endSweptArea) : base(
            sweptArea, position, extrudedDirection, depth)
        {
            EndSweptArea = endSweptArea;
        }

        public IfcProfileDef EndSweptArea { get; set; }

        public new static IfcExtrudedAreaSolidTapered FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcExtrudedAreaSolidTapered>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                SweptArea != null ? SweptArea.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                ExtrudedDirection != null ? ExtrudedDirection.ToStepValue() : "$",
                Depth != null ? Depth.ToStepValue() : "$",
                EndSweptArea != null ? EndSweptArea.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}