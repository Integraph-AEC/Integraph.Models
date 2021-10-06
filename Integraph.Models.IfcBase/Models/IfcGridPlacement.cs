using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcgridplacement.htm" />
	/// </summary>
	public class IfcGridPlacement : IfcObjectPlacement
    {
	    /// <summary>
	    ///     Construct a IfcGridPlacement with all required attributes.
	    /// </summary>
	    public IfcGridPlacement(IfcVirtualGridIntersection placementLocation)
        {
            PlacementLocation = placementLocation;
        }

	    /// <summary>
	    ///     Construct a IfcGridPlacement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcGridPlacement(IfcVirtualGridIntersection placementLocation,
            IfcGridPlacementDirectionSelect placementRefDirection)
        {
            PlacementLocation = placementLocation;
            PlacementRefDirection = placementRefDirection;
        }

        public IfcVirtualGridIntersection PlacementLocation { get; set; }
        public IfcGridPlacementDirectionSelect PlacementRefDirection { get; set; } // optional

        public new static IfcGridPlacement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcGridPlacement>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            PlacementLocation != null ? PlacementLocation.ToStepValue() : "$",
	            PlacementRefDirection != null ? PlacementRefDirection.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}