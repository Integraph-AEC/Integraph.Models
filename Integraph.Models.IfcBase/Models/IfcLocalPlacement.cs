using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclocalplacement.htm" />
	/// </summary>
	public class IfcLocalPlacement : IfcObjectPlacement
    {
	    /// <summary>
	    ///     Construct a IfcLocalPlacement with all required attributes.
	    /// </summary>
	    public IfcLocalPlacement(IfcAxis2Placement relativePlacement)
        {
            RelativePlacement = relativePlacement;
        }

	    /// <summary>
	    ///     Construct a IfcLocalPlacement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLocalPlacement(IfcObjectPlacement placementRelTo, IfcAxis2Placement relativePlacement)
        {
            PlacementRelTo = placementRelTo;
            RelativePlacement = relativePlacement;
        }

        public IfcObjectPlacement PlacementRelTo { get; set; } // optional
        public IfcAxis2Placement RelativePlacement { get; set; }

        public new static IfcLocalPlacement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLocalPlacement>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            PlacementRelTo != null ? PlacementRelTo.ToStepValue() : "$",
	            RelativePlacement != null ? RelativePlacement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}