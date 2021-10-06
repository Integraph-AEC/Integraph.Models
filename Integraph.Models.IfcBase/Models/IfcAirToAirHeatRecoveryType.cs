using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcairtoairheatrecoverytype.htm" />
	/// </summary>
	public class IfcAirToAirHeatRecoveryType : IfcEnergyConversionDeviceType
    {
	    /// <summary>
	    ///     Construct a IfcAirToAirHeatRecoveryType with all required attributes.
	    /// </summary>
	    public IfcAirToAirHeatRecoveryType(IfcGloballyUniqueId globalId, IfcAirToAirHeatRecoveryTypeEnum predefinedType)
            : base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcAirToAirHeatRecoveryType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcAirToAirHeatRecoveryType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType,
            IfcAirToAirHeatRecoveryTypeEnum predefinedType) : base(globalId, ownerHistory, name, description,
            applicableOccurrence, hasPropertySets, representationMaps, tag, elementType)
        {
            PredefinedType = predefinedType;
        }

        public IfcAirToAirHeatRecoveryTypeEnum? PredefinedType { get; set; }

        public new static IfcAirToAirHeatRecoveryType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAirToAirHeatRecoveryType>(json);
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
                PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}