using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfacereinforcementarea.htm" />
	/// </summary>
	public class IfcSurfaceReinforcementArea : IfcStructuralLoadOrResult
    {
	    /// <summary>
	    ///     Construct a IfcSurfaceReinforcementArea with all required attributes.
	    /// </summary>
	    public IfcSurfaceReinforcementArea()
        {
            SurfaceReinforcement1 = new List<IfcLengthMeasure>();
            SurfaceReinforcement2 = new List<IfcLengthMeasure>();
        }

	    /// <summary>
	    ///     Construct a IfcSurfaceReinforcementArea with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurfaceReinforcementArea(IfcLabel name, List<IfcLengthMeasure> surfaceReinforcement1,
            List<IfcLengthMeasure> surfaceReinforcement2, IfcRatioMeasure shearReinforcement) : base(name)
        {
            SurfaceReinforcement1 = surfaceReinforcement1;
            SurfaceReinforcement2 = surfaceReinforcement2;
            ShearReinforcement = shearReinforcement;
        }

        public List<IfcLengthMeasure> SurfaceReinforcement1 { get; set; } // optional
        public List<IfcLengthMeasure> SurfaceReinforcement2 { get; set; } // optional
        public IfcRatioMeasure ShearReinforcement { get; set; } // optional

        public new static IfcSurfaceReinforcementArea FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurfaceReinforcementArea>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            SurfaceReinforcement1 != null ? SurfaceReinforcement1.ToStepValue() : "$",
	            SurfaceReinforcement2 != null ? SurfaceReinforcement2.ToStepValue() : "$",
	            ShearReinforcement != null ? ShearReinforcement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}