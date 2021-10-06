using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfaceofrevolution.htm" />
	/// </summary>
	public class IfcSurfaceOfRevolution : IfcSweptSurface
    {
	    /// <summary>
	    ///     Construct a IfcSurfaceOfRevolution with all required attributes.
	    /// </summary>
	    public IfcSurfaceOfRevolution(IfcProfileDef sweptCurve, IfcAxis1Placement axisPosition) : base(sweptCurve)
        {
            AxisPosition = axisPosition;
        }

	    /// <summary>
	    ///     Construct a IfcSurfaceOfRevolution with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurfaceOfRevolution(IfcProfileDef sweptCurve, IfcAxis2Placement3D position,
            IfcAxis1Placement axisPosition) : base(sweptCurve, position)
        {
            AxisPosition = axisPosition;
        }

        public IfcAxis1Placement AxisPosition { get; set; }

        [JsonIgnore]
        public IfcLine AxisLine =>
            throw new NotImplementedException("Derived property logic has been implemented for AxisLine."); // derived

        public new static IfcSurfaceOfRevolution FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurfaceOfRevolution>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                SweptCurve != null ? SweptCurve.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                AxisPosition != null ? AxisPosition.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}