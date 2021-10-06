using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcwindow.htm" />
	/// </summary>
	public class IfcWindow : IfcBuildingElement
    {
	    /// <summary>
	    ///     Construct a IfcWindow with all required attributes.
	    /// </summary>
	    public IfcWindow(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcWindow with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcWindow(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcObjectPlacement objectPlacement, IfcProductRepresentation representation,
            IfcIdentifier tag, IfcPositiveLengthMeasure overallHeight, IfcPositiveLengthMeasure overallWidth,
            IfcWindowTypeEnum predefinedType, IfcWindowTypePartitioningEnum partitioningType,
            IfcLabel userDefinedPartitioningType) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation, tag)
        {
            OverallHeight = overallHeight;
            OverallWidth = overallWidth;
            PredefinedType = predefinedType;
            PartitioningType = partitioningType;
            UserDefinedPartitioningType = userDefinedPartitioningType;
        }

        public IfcPositiveLengthMeasure OverallHeight { get; set; } // optional
        public IfcPositiveLengthMeasure OverallWidth { get; set; } // optional
        public IfcWindowTypeEnum? PredefinedType { get; set; } // optional
        public IfcWindowTypePartitioningEnum? PartitioningType { get; set; } // optional
        public IfcLabel UserDefinedPartitioningType { get; set; } // optional

        public new static IfcWindow FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcWindow>(json);
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