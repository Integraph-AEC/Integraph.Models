using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfillareastylehatching.htm" />
	/// </summary>
	public class IfcFillAreaStyleHatching : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcFillAreaStyleHatching with all required attributes.
	    /// </summary>
	    public IfcFillAreaStyleHatching(IfcCurveStyle hatchLineAppearance,
            IfcHatchLineDistanceSelect startOfNextHatchLine, IfcPlaneAngleMeasure hatchLineAngle)
        {
            HatchLineAppearance = hatchLineAppearance;
            StartOfNextHatchLine = startOfNextHatchLine;
            HatchLineAngle = hatchLineAngle;
        }

	    /// <summary>
	    ///     Construct a IfcFillAreaStyleHatching with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFillAreaStyleHatching(IfcCurveStyle hatchLineAppearance,
            IfcHatchLineDistanceSelect startOfNextHatchLine, IfcCartesianPoint pointOfReferenceHatchLine,
            IfcCartesianPoint patternStart, IfcPlaneAngleMeasure hatchLineAngle)
        {
            HatchLineAppearance = hatchLineAppearance;
            StartOfNextHatchLine = startOfNextHatchLine;
            PointOfReferenceHatchLine = pointOfReferenceHatchLine;
            PatternStart = patternStart;
            HatchLineAngle = hatchLineAngle;
        }

        public IfcCurveStyle HatchLineAppearance { get; set; }
        public IfcHatchLineDistanceSelect StartOfNextHatchLine { get; set; }
        public IfcCartesianPoint PointOfReferenceHatchLine { get; set; } // optional
        public IfcCartesianPoint PatternStart { get; set; } // optional
        public IfcPlaneAngleMeasure HatchLineAngle { get; set; }

        public new static IfcFillAreaStyleHatching FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFillAreaStyleHatching>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                HatchLineAppearance != null ? HatchLineAppearance.ToStepValue() : "$",
                StartOfNextHatchLine != null ? StartOfNextHatchLine.ToStepValue() : "$",
                PointOfReferenceHatchLine != null ? PointOfReferenceHatchLine.ToStepValue() : "$",
                PatternStart != null ? PatternStart.ToStepValue() : "$",
                HatchLineAngle != null ? HatchLineAngle.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}