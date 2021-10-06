using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrevolvedareasolidtapered.htm" />
	/// </summary>
	public class IfcRevolvedAreaSolidTapered : IfcRevolvedAreaSolid
    {
	    /// <summary>
	    ///     Construct a IfcRevolvedAreaSolidTapered with all required attributes.
	    /// </summary>
	    public IfcRevolvedAreaSolidTapered(IfcProfileDef sweptArea, IfcAxis1Placement axis, IfcPlaneAngleMeasure angle,
            IfcProfileDef endSweptArea) : base(sweptArea, axis, angle)
        {
            EndSweptArea = endSweptArea;
        }

	    /// <summary>
	    ///     Construct a IfcRevolvedAreaSolidTapered with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRevolvedAreaSolidTapered(IfcProfileDef sweptArea, IfcAxis2Placement3D position,
            IfcAxis1Placement axis, IfcPlaneAngleMeasure angle, IfcProfileDef endSweptArea) : base(sweptArea, position,
            axis, angle)
        {
            EndSweptArea = endSweptArea;
        }

        public IfcProfileDef EndSweptArea { get; set; }

        public new static IfcRevolvedAreaSolidTapered FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRevolvedAreaSolidTapered>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                SweptArea != null ? SweptArea.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                Axis != null ? Axis.ToStepValue() : "$",
                Angle != null ? Angle.ToStepValue() : "$",
                EndSweptArea != null ? EndSweptArea.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}