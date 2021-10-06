using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcwindowtype.htm" />
	/// </summary>
	public class IfcWindowType : IfcBuildingElementType
    {
	    /// <summary>
	    ///     Construct a IfcWindowType with all required attributes.
	    /// </summary>
	    public IfcWindowType(IfcGloballyUniqueId globalId, IfcWindowTypeEnum predefinedType,
            IfcWindowTypePartitioningEnum partitioningType) : base(globalId)
        {
            PredefinedType = predefinedType;
            PartitioningType = partitioningType;
        }

	    /// <summary>
	    ///     Construct a IfcWindowType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcWindowType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType,
            IfcWindowTypeEnum predefinedType, IfcWindowTypePartitioningEnum partitioningType,
            IfcBoolean parameterTakesPrecedence, IfcLabel userDefinedPartitioningType) : base(globalId, ownerHistory,
            name, description, applicableOccurrence, hasPropertySets, representationMaps, tag, elementType)
        {
            PredefinedType = predefinedType;
            PartitioningType = partitioningType;
            ParameterTakesPrecedence = parameterTakesPrecedence;
            UserDefinedPartitioningType = userDefinedPartitioningType;
        }

        public IfcWindowTypeEnum? PredefinedType { get; set; }
        public IfcWindowTypePartitioningEnum? PartitioningType { get; set; }
        public IfcBoolean ParameterTakesPrecedence { get; set; } // optional
        public IfcLabel UserDefinedPartitioningType { get; set; } // optional

        public new static IfcWindowType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcWindowType>(json);
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
                PartitioningType.ToStepValue(),
                ParameterTakesPrecedence != null ? ParameterTakesPrecedence.ToStepValue() : "$",
                UserDefinedPartitioningType != null ? UserDefinedPartitioningType.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}