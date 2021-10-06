using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcspatialzonetype.htm" />
	/// </summary>
	public class IfcSpatialZoneType : IfcSpatialElementType
    {
	    /// <summary>
	    ///     Construct a IfcSpatialZoneType with all required attributes.
	    /// </summary>
	    public IfcSpatialZoneType(IfcGloballyUniqueId globalId, IfcSpatialZoneTypeEnum predefinedType) : base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcSpatialZoneType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSpatialZoneType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType,
            IfcSpatialZoneTypeEnum predefinedType, IfcLabel longName) : base(globalId, ownerHistory, name, description,
            applicableOccurrence, hasPropertySets, representationMaps, tag, elementType)
        {
            PredefinedType = predefinedType;
            LongName = longName;
        }

        public IfcSpatialZoneTypeEnum? PredefinedType { get; set; }
        public IfcLabel LongName { get; set; } // optional

        public new static IfcSpatialZoneType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSpatialZoneType>(json);
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
	            PredefinedType.ToStepValue(),
	            LongName != null ? LongName.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}