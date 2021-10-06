using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbuildingstorey.htm" />
	/// </summary>
	public class IfcBuildingStorey : IfcSpatialStructureElement
    {
	    /// <summary>
	    ///     Construct a IfcBuildingStorey with all required attributes.
	    /// </summary>
	    public IfcBuildingStorey(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcBuildingStorey with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBuildingStorey(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcLabel longName, IfcElementCompositionEnum compositionType,
            IfcLengthMeasure elevation) : base(globalId, ownerHistory, name, description, objectType, objectPlacement,
            representation, longName, compositionType)
        {
            Elevation = elevation;
        }

        public IfcLengthMeasure Elevation { get; set; } // optional

        public new static IfcBuildingStorey FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBuildingStorey>(json);
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
	            Elevation != null ? Elevation.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}