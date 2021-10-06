using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctendontype.htm" />
	/// </summary>
	public class IfcTendonType : IfcReinforcingElementType
    {
	    /// <summary>
	    ///     Construct a IfcTendonType with all required attributes.
	    /// </summary>
	    public IfcTendonType(IfcGloballyUniqueId globalId, IfcTendonTypeEnum predefinedType) : base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcTendonType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTendonType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType,
            IfcTendonTypeEnum predefinedType, IfcPositiveLengthMeasure nominalDiameter, IfcAreaMeasure crossSectionArea,
            IfcPositiveLengthMeasure sheathDiameter) : base(globalId, ownerHistory, name, description,
            applicableOccurrence, hasPropertySets, representationMaps, tag, elementType)
        {
            PredefinedType = predefinedType;
            NominalDiameter = nominalDiameter;
            CrossSectionArea = crossSectionArea;
            SheathDiameter = sheathDiameter;
        }

        public IfcTendonTypeEnum? PredefinedType { get; set; }
        public IfcPositiveLengthMeasure NominalDiameter { get; set; } // optional
        public IfcAreaMeasure CrossSectionArea { get; set; } // optional
        public IfcPositiveLengthMeasure SheathDiameter { get; set; } // optional

        public new static IfcTendonType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTendonType>(json);
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
	            NominalDiameter != null ? NominalDiameter.ToStepValue() : "$",
	            CrossSectionArea != null ? CrossSectionArea.ToStepValue() : "$",
	            SheathDiameter != null ? SheathDiameter.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}