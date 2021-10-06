using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcwindowstandardcase.htm" />
	/// </summary>
	public class IfcWindowStandardCase : IfcWindow
    {
	    /// <summary>
	    ///     Construct a IfcWindowStandardCase with all required attributes.
	    /// </summary>
	    public IfcWindowStandardCase(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcWindowStandardCase with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcWindowStandardCase(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcPositiveLengthMeasure overallHeight,
            IfcPositiveLengthMeasure overallWidth, IfcWindowTypeEnum predefinedType,
            IfcWindowTypePartitioningEnum partitioningType, IfcLabel userDefinedPartitioningType) : base(globalId,
            ownerHistory, name, description, objectType, objectPlacement, representation, tag, overallHeight,
            overallWidth, predefinedType, partitioningType, userDefinedPartitioningType)
        {
        }

        public new static IfcWindowStandardCase FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcWindowStandardCase>(json);
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
	            PartitioningType.ToStepValue(),
	            UserDefinedPartitioningType != null ? UserDefinedPartitioningType.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}