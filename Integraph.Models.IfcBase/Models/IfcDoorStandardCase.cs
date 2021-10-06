using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdoorstandardcase.htm" />
	/// </summary>
	public class IfcDoorStandardCase : IfcDoor
    {
	    /// <summary>
	    ///     Construct a IfcDoorStandardCase with all required attributes.
	    /// </summary>
	    public IfcDoorStandardCase(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcDoorStandardCase with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDoorStandardCase(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcPositiveLengthMeasure overallHeight,
            IfcPositiveLengthMeasure overallWidth, IfcDoorTypeEnum predefinedType,
            IfcDoorTypeOperationEnum operationType, IfcLabel userDefinedOperationType) : base(globalId, ownerHistory,
            name, description, objectType, objectPlacement, representation, tag, overallHeight, overallWidth,
            predefinedType, operationType, userDefinedOperationType)
        {
        }

        public new static IfcDoorStandardCase FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDoorStandardCase>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ObjectType != null ? ObjectType.ToStepValue() : "$",
	            ObjectPlacement != null ? ObjectPlacement.ToStepValue() : "$",
	            Representation != null ? Representation.ToStepValue() : "$",
	            Tag != null ? Tag.ToStepValue() : "$",
	            OverallHeight != null ? OverallHeight.ToStepValue() : "$",
	            OverallWidth != null ? OverallWidth.ToStepValue() : "$",
	            PredefinedType.ToStepValue(),
	            OperationType.ToStepValue(),
	            UserDefinedOperationType != null ? UserDefinedOperationType.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}