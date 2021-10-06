using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctoroidalsurface.htm" />
	/// </summary>
	public class IfcToroidalSurface : IfcElementarySurface
    {
	    /// <summary>
	    ///     Construct a IfcToroidalSurface with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcToroidalSurface(IfcAxis2Placement3D position, IfcPositiveLengthMeasure majorRadius,
            IfcPositiveLengthMeasure minorRadius) : base(position)
        {
            MajorRadius = majorRadius;
            MinorRadius = minorRadius;
        }

        public IfcPositiveLengthMeasure MajorRadius { get; set; }
        public IfcPositiveLengthMeasure MinorRadius { get; set; }

        public new static IfcToroidalSurface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcToroidalSurface>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Position != null ? Position.ToStepValue() : "$",
                MajorRadius != null ? MajorRadius.ToStepValue() : "$",
                MinorRadius != null ? MinorRadius.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}