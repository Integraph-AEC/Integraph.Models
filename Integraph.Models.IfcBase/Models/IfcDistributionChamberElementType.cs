using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdistributionchamberelementtype.htm" />
	/// </summary>
	public class IfcDistributionChamberElementType : IfcDistributionFlowElementType
    {
	    /// <summary>
	    ///     Construct a IfcDistributionChamberElementType with all required attributes.
	    /// </summary>
	    public IfcDistributionChamberElementType(IfcGloballyUniqueId globalId,
            IfcDistributionChamberElementTypeEnum predefinedType) : base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcDistributionChamberElementType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDistributionChamberElementType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory,
            IfcLabel name, IfcText description, IfcIdentifier applicableOccurrence,
            List<IfcPropertySetDefinition> hasPropertySets, List<IfcRepresentationMap> representationMaps, IfcLabel tag,
            IfcLabel elementType, IfcDistributionChamberElementTypeEnum predefinedType) : base(globalId, ownerHistory,
            name, description, applicableOccurrence, hasPropertySets, representationMaps, tag, elementType)
        {
            PredefinedType = predefinedType;
        }

        public IfcDistributionChamberElementTypeEnum? PredefinedType { get; set; }

        public new static IfcDistributionChamberElementType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDistributionChamberElementType>(json);
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