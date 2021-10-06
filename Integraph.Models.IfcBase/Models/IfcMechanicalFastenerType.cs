using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmechanicalfastenertype.htm" />
	/// </summary>
	public class IfcMechanicalFastenerType : IfcElementComponentType
    {
	    /// <summary>
	    ///     Construct a IfcMechanicalFastenerType with all required attributes.
	    /// </summary>
	    public IfcMechanicalFastenerType(IfcGloballyUniqueId globalId, IfcMechanicalFastenerTypeEnum predefinedType) :
            base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcMechanicalFastenerType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMechanicalFastenerType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType,
            IfcMechanicalFastenerTypeEnum predefinedType, IfcPositiveLengthMeasure nominalDiameter,
            IfcPositiveLengthMeasure nominalLength) : base(globalId, ownerHistory, name, description,
            applicableOccurrence, hasPropertySets, representationMaps, tag, elementType)
        {
            PredefinedType = predefinedType;
            NominalDiameter = nominalDiameter;
            NominalLength = nominalLength;
        }

        public IfcMechanicalFastenerTypeEnum? PredefinedType { get; set; }
        public IfcPositiveLengthMeasure NominalDiameter { get; set; } // optional
        public IfcPositiveLengthMeasure NominalLength { get; set; } // optional

        public new static IfcMechanicalFastenerType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMechanicalFastenerType>(json);
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
                NominalLength != null ? NominalLength.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}