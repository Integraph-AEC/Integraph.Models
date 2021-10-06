using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbuilding.htm" />
	/// </summary>
	public class IfcBuilding : IfcSpatialStructureElement
    {
	    /// <summary>
	    ///     Construct a IfcBuilding with all required attributes.
	    /// </summary>
	    public IfcBuilding(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcBuilding with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBuilding(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcLabel longName, IfcElementCompositionEnum compositionType,
            IfcLengthMeasure elevationOfRefHeight, IfcLengthMeasure elevationOfTerrain,
            IfcPostalAddress buildingAddress) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation, longName, compositionType)
        {
            ElevationOfRefHeight = elevationOfRefHeight;
            ElevationOfTerrain = elevationOfTerrain;
            BuildingAddress = buildingAddress;
        }

        public IfcLengthMeasure ElevationOfRefHeight { get; set; } // optional
        public IfcLengthMeasure ElevationOfTerrain { get; set; } // optional
        public IfcPostalAddress BuildingAddress { get; set; } // optional

        public new static IfcBuilding FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBuilding>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ObjectType != null ? ObjectType.ToStepValue() : "$",
	            ObjectPlacement != null ? ObjectPlacement.ToStepValue() : "$",
	            Representation != null ? Representation.ToStepValue() : "$",
	            LongName != null ? LongName.ToStepValue() : "$",
	            CompositionType.ToStepValue(),
	            ElevationOfRefHeight != null ? ElevationOfRefHeight.ToStepValue() : "$",
	            ElevationOfTerrain != null ? ElevationOfTerrain.ToStepValue() : "$",
	            BuildingAddress != null ? BuildingAddress.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}