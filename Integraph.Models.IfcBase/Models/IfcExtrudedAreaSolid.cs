using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcextrudedareasolid.htm" />
	/// </summary>
	public class IfcExtrudedAreaSolid : IfcSweptAreaSolid
    {
	    /// <summary>
	    ///     Construct a IfcExtrudedAreaSolid with all required attributes.
	    /// </summary>
	    public IfcExtrudedAreaSolid(IfcProfileDef sweptArea, IfcDirection extrudedDirection,
            IfcPositiveLengthMeasure depth) : base(sweptArea)
        {
            ExtrudedDirection = extrudedDirection;
            Depth = depth;
        }

	    /// <summary>
	    ///     Construct a IfcExtrudedAreaSolid with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcExtrudedAreaSolid(IfcProfileDef sweptArea, IfcAxis2Placement3D position,
            IfcDirection extrudedDirection, IfcPositiveLengthMeasure depth) : base(sweptArea, position)
        {
            ExtrudedDirection = extrudedDirection;
            Depth = depth;
        }

        public IfcDirection ExtrudedDirection { get; set; }
        public IfcPositiveLengthMeasure Depth { get; set; }

        public new static IfcExtrudedAreaSolid FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcExtrudedAreaSolid>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                SweptArea != null ? SweptArea.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                ExtrudedDirection != null ? ExtrudedDirection.ToStepValue() : "$",
                Depth != null ? Depth.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}