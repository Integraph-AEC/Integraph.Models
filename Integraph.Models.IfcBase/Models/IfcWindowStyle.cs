using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcwindowstyle.htm" />
	/// </summary>
	public class IfcWindowStyle : IfcTypeProduct
    {
	    /// <summary>
	    ///     Construct a IfcWindowStyle with all required attributes.
	    /// </summary>
	    public IfcWindowStyle(IfcGloballyUniqueId globalId, IfcWindowStyleConstructionEnum constructionType,
            IfcWindowStyleOperationEnum operationType, IfcBoolean parameterTakesPrecedence,
            IfcBoolean sizeable) : base(globalId)
        {
            ConstructionType = constructionType;
            OperationType = operationType;
            ParameterTakesPrecedence = parameterTakesPrecedence;
            Sizeable = sizeable;
        }

	    /// <summary>
	    ///     Construct a IfcWindowStyle with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcWindowStyle(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag,
            IfcWindowStyleConstructionEnum constructionType, IfcWindowStyleOperationEnum operationType,
            IfcBoolean parameterTakesPrecedence, IfcBoolean sizeable) : base(globalId, ownerHistory, name, description,
            applicableOccurrence, hasPropertySets, representationMaps, tag)
        {
            ConstructionType = constructionType;
            OperationType = operationType;
            ParameterTakesPrecedence = parameterTakesPrecedence;
            Sizeable = sizeable;
        }

        public IfcWindowStyleConstructionEnum? ConstructionType { get; set; }
        public IfcWindowStyleOperationEnum? OperationType { get; set; }
        public IfcBoolean ParameterTakesPrecedence { get; set; }
        public IfcBoolean Sizeable { get; set; }

        public new static IfcWindowStyle FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcWindowStyle>(json);
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
                ConstructionType.ToStepValue(),
                OperationType.ToStepValue(),
                ParameterTakesPrecedence != null ? ParameterTakesPrecedence.ToStepValue() : "$",
                Sizeable != null ? Sizeable.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}