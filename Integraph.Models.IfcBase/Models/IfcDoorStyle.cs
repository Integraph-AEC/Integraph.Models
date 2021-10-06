using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdoorstyle.htm" />
	/// </summary>
	public class IfcDoorStyle : IfcTypeProduct
    {
	    /// <summary>
	    ///     Construct a IfcDoorStyle with all required attributes.
	    /// </summary>
	    public IfcDoorStyle(IfcGloballyUniqueId globalId, IfcDoorStyleOperationEnum operationType,
            IfcDoorStyleConstructionEnum constructionType, IfcBoolean parameterTakesPrecedence,
            IfcBoolean sizeable) : base(globalId)
        {
            OperationType = operationType;
            ConstructionType = constructionType;
            ParameterTakesPrecedence = parameterTakesPrecedence;
            Sizeable = sizeable;
        }

	    /// <summary>
	    ///     Construct a IfcDoorStyle with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDoorStyle(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcDoorStyleOperationEnum operationType,
            IfcDoorStyleConstructionEnum constructionType, IfcBoolean parameterTakesPrecedence, IfcBoolean sizeable) :
            base(globalId, ownerHistory, name, description, applicableOccurrence, hasPropertySets, representationMaps,
                tag)
        {
            OperationType = operationType;
            ConstructionType = constructionType;
            ParameterTakesPrecedence = parameterTakesPrecedence;
            Sizeable = sizeable;
        }

        public IfcDoorStyleOperationEnum? OperationType { get; set; }
        public IfcDoorStyleConstructionEnum? ConstructionType { get; set; }
        public IfcBoolean ParameterTakesPrecedence { get; set; }
        public IfcBoolean Sizeable { get; set; }

        public new static IfcDoorStyle FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDoorStyle>(json);
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
                OperationType.ToStepValue(),
                ConstructionType.ToStepValue(),
                ParameterTakesPrecedence != null ? ParameterTakesPrecedence.ToStepValue() : "$",
                Sizeable != null ? Sizeable.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}