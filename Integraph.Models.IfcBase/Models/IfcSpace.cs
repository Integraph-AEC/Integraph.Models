using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcspace.htm" />
	/// </summary>
	public class IfcSpace : IfcSpatialStructureElement
    {
	    /// <summary>
	    ///     Construct a IfcSpace with all required attributes.
	    /// </summary>
	    public IfcSpace(IfcGloballyUniqueId globalId) : base(globalId)
        {
            HasCoverings = new List<IfcRelCoversSpaces>();
            BoundedBy = new List<IfcRelSpaceBoundary>();
        }

	    /// <summary>
	    ///     Construct a IfcSpace with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSpace(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcObjectPlacement objectPlacement, IfcProductRepresentation representation,
            IfcLabel longName, IfcElementCompositionEnum compositionType, IfcSpaceTypeEnum predefinedType,
            IfcLengthMeasure elevationWithFlooring) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation, longName, compositionType)
        {
            HasCoverings = new List<IfcRelCoversSpaces>();
            BoundedBy = new List<IfcRelSpaceBoundary>();

            PredefinedType = predefinedType;
            ElevationWithFlooring = elevationWithFlooring;
        }

        public IfcSpaceTypeEnum? PredefinedType { get; set; } // optional
        public IfcLengthMeasure ElevationWithFlooring { get; set; } // optional
        public List<IfcRelCoversSpaces> HasCoverings { get; set; } // inverse
        public List<IfcRelSpaceBoundary> BoundedBy { get; set; } // inverse

        public new static IfcSpace FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSpace>(json);
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
	            PredefinedType.ToStepValue(),
	            ElevationWithFlooring != null ? ElevationWithFlooring.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}