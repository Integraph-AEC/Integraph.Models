using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdoorliningproperties.htm" />
	/// </summary>
	public class IfcDoorLiningProperties : IfcPreDefinedPropertySet
    {
	    /// <summary>
	    ///     Construct a IfcDoorLiningProperties with all required attributes.
	    /// </summary>
	    public IfcDoorLiningProperties(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcDoorLiningProperties with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDoorLiningProperties(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcPositiveLengthMeasure liningDepth, IfcNonNegativeLengthMeasure liningThickness,
            IfcPositiveLengthMeasure thresholdDepth, IfcNonNegativeLengthMeasure thresholdThickness,
            IfcNonNegativeLengthMeasure transomThickness, IfcLengthMeasure transomOffset, IfcLengthMeasure liningOffset,
            IfcLengthMeasure thresholdOffset, IfcPositiveLengthMeasure casingThickness,
            IfcPositiveLengthMeasure casingDepth, IfcShapeAspect shapeAspectStyle,
            IfcLengthMeasure liningToPanelOffsetX, IfcLengthMeasure liningToPanelOffsetY) : base(globalId, ownerHistory,
            name, description)
        {
            LiningDepth = liningDepth;
            LiningThickness = liningThickness;
            ThresholdDepth = thresholdDepth;
            ThresholdThickness = thresholdThickness;
            TransomThickness = transomThickness;
            TransomOffset = transomOffset;
            LiningOffset = liningOffset;
            ThresholdOffset = thresholdOffset;
            CasingThickness = casingThickness;
            CasingDepth = casingDepth;
            ShapeAspectStyle = shapeAspectStyle;
            LiningToPanelOffsetX = liningToPanelOffsetX;
            LiningToPanelOffsetY = liningToPanelOffsetY;
        }

        public IfcPositiveLengthMeasure LiningDepth { get; set; } // optional
        public IfcNonNegativeLengthMeasure LiningThickness { get; set; } // optional
        public IfcPositiveLengthMeasure ThresholdDepth { get; set; } // optional
        public IfcNonNegativeLengthMeasure ThresholdThickness { get; set; } // optional
        public IfcNonNegativeLengthMeasure TransomThickness { get; set; } // optional
        public IfcLengthMeasure TransomOffset { get; set; } // optional
        public IfcLengthMeasure LiningOffset { get; set; } // optional
        public IfcLengthMeasure ThresholdOffset { get; set; } // optional
        public IfcPositiveLengthMeasure CasingThickness { get; set; } // optional
        public IfcPositiveLengthMeasure CasingDepth { get; set; } // optional
        public IfcShapeAspect ShapeAspectStyle { get; set; } // optional
        public IfcLengthMeasure LiningToPanelOffsetX { get; set; } // optional
        public IfcLengthMeasure LiningToPanelOffsetY { get; set; } // optional

        public new static IfcDoorLiningProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDoorLiningProperties>(json);
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
	            ThresholdDepth != null ? ThresholdDepth.ToStepValue() : "$",
	            ThresholdThickness != null ? ThresholdThickness.ToStepValue() : "$",
	            TransomThickness != null ? TransomThickness.ToStepValue() : "$",
	            TransomOffset != null ? TransomOffset.ToStepValue() : "$",
	            LiningOffset != null ? LiningOffset.ToStepValue() : "$",
	            ThresholdOffset != null ? ThresholdOffset.ToStepValue() : "$",
	            CasingThickness != null ? CasingThickness.ToStepValue() : "$",
	            CasingDepth != null ? CasingDepth.ToStepValue() : "$",
	            ShapeAspectStyle != null ? ShapeAspectStyle.ToStepValue() : "$",
	            LiningToPanelOffsetX != null ? LiningToPanelOffsetX.ToStepValue() : "$",
	            LiningToPanelOffsetY != null ? LiningToPanelOffsetY.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}