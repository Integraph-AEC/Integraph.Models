using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfurnituretype.htm" />
	/// </summary>
	public class IfcFurnitureType : IfcFurnishingElementType
    {
	    /// <summary>
	    ///     Construct a IfcFurnitureType with all required attributes.
	    /// </summary>
	    public IfcFurnitureType(IfcGloballyUniqueId globalId, IfcAssemblyPlaceEnum assemblyPlace) : base(globalId)
        {
            AssemblyPlace = assemblyPlace;
        }

	    /// <summary>
	    ///     Construct a IfcFurnitureType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFurnitureType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType,
            IfcAssemblyPlaceEnum assemblyPlace, IfcFurnitureTypeEnum predefinedType) : base(globalId, ownerHistory,
            name, description, applicableOccurrence, hasPropertySets, representationMaps, tag, elementType)
        {
            AssemblyPlace = assemblyPlace;
            PredefinedType = predefinedType;
        }

        public IfcAssemblyPlaceEnum? AssemblyPlace { get; set; }
        public IfcFurnitureTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcFurnitureType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFurnitureType>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ApplicableOccurrence != null ? ApplicableOccurrence.ToStepValue() : "$",
	            HasPropertySets != null ? HasPropertySets.ToStepValue() : "$",
	            RepresentationMaps != null ? RepresentationMaps.ToStepValue() : "$",
	            Tag != null ? Tag.ToStepValue() : "$",
	            ElementType != null ? ElementType.ToStepValue() : "$",
	            AssemblyPlace.ToStepValue(),
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}