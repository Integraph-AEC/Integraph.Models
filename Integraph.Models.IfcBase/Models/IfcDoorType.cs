using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdoortype.htm" />
	/// </summary>
	public class IfcDoorType : IfcBuildingElementType
    {
	    /// <summary>
	    ///     Construct a IfcDoorType with all required attributes.
	    /// </summary>
	    public IfcDoorType(IfcGloballyUniqueId globalId, IfcDoorTypeEnum predefinedType,
            IfcDoorTypeOperationEnum operationType) : base(globalId)
        {
            PredefinedType = predefinedType;
            OperationType = operationType;
        }

	    /// <summary>
	    ///     Construct a IfcDoorType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDoorType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType,
            IfcDoorTypeEnum predefinedType, IfcDoorTypeOperationEnum operationType, IfcBoolean parameterTakesPrecedence,
            IfcLabel userDefinedOperationType) : base(globalId, ownerHistory, name, description, applicableOccurrence,
            hasPropertySets, representationMaps, tag, elementType)
        {
            PredefinedType = predefinedType;
            OperationType = operationType;
            ParameterTakesPrecedence = parameterTakesPrecedence;
            UserDefinedOperationType = userDefinedOperationType;
        }

        public IfcDoorTypeEnum? PredefinedType { get; set; }
        public IfcDoorTypeOperationEnum? OperationType { get; set; }
        public IfcBoolean ParameterTakesPrecedence { get; set; } // optional
        public IfcLabel UserDefinedOperationType { get; set; } // optional

        public new static IfcDoorType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDoorType>(json);
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
                OperationType.ToStepValue(),
                ParameterTakesPrecedence != null ? ParameterTakesPrecedence.ToStepValue() : "$",
                UserDefinedOperationType != null ? UserDefinedOperationType.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}