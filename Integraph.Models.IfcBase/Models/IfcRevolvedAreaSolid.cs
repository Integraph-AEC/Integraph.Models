using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrevolvedareasolid.htm" />
	/// </summary>
	public class IfcRevolvedAreaSolid : IfcSweptAreaSolid
    {
	    /// <summary>
	    ///     Construct a IfcRevolvedAreaSolid with all required attributes.
	    /// </summary>
	    public IfcRevolvedAreaSolid(IfcProfileDef sweptArea, IfcAxis1Placement axis, IfcPlaneAngleMeasure angle) :
            base(sweptArea)
        {
            Axis = axis;
            Angle = angle;
        }

	    /// <summary>
	    ///     Construct a IfcRevolvedAreaSolid with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRevolvedAreaSolid(IfcProfileDef sweptArea, IfcAxis2Placement3D position, IfcAxis1Placement axis,
            IfcPlaneAngleMeasure angle) : base(sweptArea, position)
        {
            Axis = axis;
            Angle = angle;
        }

        public IfcAxis1Placement Axis { get; set; }
        public IfcPlaneAngleMeasure Angle { get; set; }

        [JsonIgnore]
        public IfcLine AxisLine =>
            throw new NotImplementedException("Derived property logic has been implemented for AxisLine."); // derived

        public new static IfcRevolvedAreaSolid FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRevolvedAreaSolid>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                SweptArea != null ? SweptArea.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                Axis != null ? Axis.ToStepValue() : "$",
                Angle != null ? Angle.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}