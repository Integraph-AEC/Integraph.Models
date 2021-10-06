using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfaceoflinearextrusion.htm" />
	/// </summary>
	public class IfcSurfaceOfLinearExtrusion : IfcSweptSurface
    {
	    /// <summary>
	    ///     Construct a IfcSurfaceOfLinearExtrusion with all required attributes.
	    /// </summary>
	    public IfcSurfaceOfLinearExtrusion(IfcProfileDef sweptCurve, IfcDirection extrudedDirection,
            IfcLengthMeasure depth) : base(sweptCurve)
        {
            ExtrudedDirection = extrudedDirection;
            Depth = depth;
        }

	    /// <summary>
	    ///     Construct a IfcSurfaceOfLinearExtrusion with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurfaceOfLinearExtrusion(IfcProfileDef sweptCurve, IfcAxis2Placement3D position,
            IfcDirection extrudedDirection, IfcLengthMeasure depth) : base(sweptCurve, position)
        {
            ExtrudedDirection = extrudedDirection;
            Depth = depth;
        }

        public IfcDirection ExtrudedDirection { get; set; }
        public IfcLengthMeasure Depth { get; set; }

        [JsonIgnore]
        public IfcVector ExtrusionAxis =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for ExtrusionAxis."); // derived

        public new static IfcSurfaceOfLinearExtrusion FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurfaceOfLinearExtrusion>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                SweptCurve != null ? SweptCurve.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                ExtrudedDirection != null ? ExtrudedDirection.ToStepValue() : "$",
                Depth != null ? Depth.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}