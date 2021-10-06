using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcwindowliningproperties.htm" />
	/// </summary>
	public class IfcWindowLiningProperties : IfcPreDefinedPropertySet
    {
	    /// <summary>
	    ///     Construct a IfcWindowLiningProperties with all required attributes.
	    /// </summary>
	    public IfcWindowLiningProperties(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcWindowLiningProperties with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcWindowLiningProperties(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcPositiveLengthMeasure liningDepth, IfcNonNegativeLengthMeasure liningThickness,
            IfcNonNegativeLengthMeasure transomThickness, IfcNonNegativeLengthMeasure mullionThickness,
            IfcNormalisedRatioMeasure firstTransomOffset, IfcNormalisedRatioMeasure secondTransomOffset,
            IfcNormalisedRatioMeasure firstMullionOffset, IfcNormalisedRatioMeasure secondMullionOffset,
            IfcShapeAspect shapeAspectStyle, IfcLengthMeasure liningOffset, IfcLengthMeasure liningToPanelOffsetX,
            IfcLengthMeasure liningToPanelOffsetY) : base(globalId, ownerHistory, name, description)
        {
            LiningDepth = liningDepth;
            LiningThickness = liningThickness;
            TransomThickness = transomThickness;
            MullionThickness = mullionThickness;
            FirstTransomOffset = firstTransomOffset;
            SecondTransomOffset = secondTransomOffset;
            FirstMullionOffset = firstMullionOffset;
            SecondMullionOffset = secondMullionOffset;
            ShapeAspectStyle = shapeAspectStyle;
            LiningOffset = liningOffset;
            LiningToPanelOffsetX = liningToPanelOffsetX;
            LiningToPanelOffsetY = liningToPanelOffsetY;
        }

        public IfcPositiveLengthMeasure LiningDepth { get; set; } // optional
        public IfcNonNegativeLengthMeasure LiningThickness { get; set; } // optional
        public IfcNonNegativeLengthMeasure TransomThickness { get; set; } // optional
        public IfcNonNegativeLengthMeasure MullionThickness { get; set; } // optional
        public IfcNormalisedRatioMeasure FirstTransomOffset { get; set; } // optional
        public IfcNormalisedRatioMeasure SecondTransomOffset { get; set; } // optional
        public IfcNormalisedRatioMeasure FirstMullionOffset { get; set; } // optional
        public IfcNormalisedRatioMeasure SecondMullionOffset { get; set; } // optional
        public IfcShapeAspect ShapeAspectStyle { get; set; } // optional
        public IfcLengthMeasure LiningOffset { get; set; } // optional
        public IfcLengthMeasure LiningToPanelOffsetX { get; set; } // optional
        public IfcLengthMeasure LiningToPanelOffsetY { get; set; } // optional

        public new static IfcWindowLiningProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcWindowLiningProperties>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            LiningDepth != null ? LiningDepth.ToStepValue() : "$",
	            LiningThickness != null ? LiningThickness.ToStepValue() : "$",
	            TransomThickness != null ? TransomThickness.ToStepValue() : "$",
	            MullionThickness != null ? MullionThickness.ToStepValue() : "$",
	            FirstTransomOffset != null ? FirstTransomOffset.ToStepValue() : "$",
	            SecondTransomOffset != null ? SecondTransomOffset.ToStepValue() : "$",
	            FirstMullionOffset != null ? FirstMullionOffset.ToStepValue() : "$",
	            SecondMullionOffset != null ? SecondMullionOffset.ToStepValue() : "$",
	            ShapeAspectStyle != null ? ShapeAspectStyle.ToStepValue() : "$",
	            LiningOffset != null ? LiningOffset.ToStepValue() : "$",
	            LiningToPanelOffsetX != null ? LiningToPanelOffsetX.ToStepValue() : "$",
	            LiningToPanelOffsetY != null ? LiningToPanelOffsetY.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}