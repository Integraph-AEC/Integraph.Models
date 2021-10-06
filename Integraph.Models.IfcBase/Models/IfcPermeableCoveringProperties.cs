using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpermeablecoveringproperties.htm" />
	/// </summary>
	public class IfcPermeableCoveringProperties : IfcPreDefinedPropertySet
    {
	    /// <summary>
	    ///     Construct a IfcPermeableCoveringProperties with all required attributes.
	    /// </summary>
	    public IfcPermeableCoveringProperties(IfcGloballyUniqueId globalId,
            IfcPermeableCoveringOperationEnum operationType, IfcWindowPanelPositionEnum panelPosition) : base(globalId)
        {
            OperationType = operationType;
            PanelPosition = panelPosition;
        }

	    /// <summary>
	    ///     Construct a IfcPermeableCoveringProperties with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPermeableCoveringProperties(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcPermeableCoveringOperationEnum operationType,
            IfcWindowPanelPositionEnum panelPosition, IfcPositiveLengthMeasure frameDepth,
            IfcPositiveLengthMeasure frameThickness, IfcShapeAspect shapeAspectStyle) : base(globalId, ownerHistory,
            name, description)
        {
            OperationType = operationType;
            PanelPosition = panelPosition;
            FrameDepth = frameDepth;
            FrameThickness = frameThickness;
            ShapeAspectStyle = shapeAspectStyle;
        }

        public IfcPermeableCoveringOperationEnum? OperationType { get; set; }
        public IfcWindowPanelPositionEnum? PanelPosition { get; set; }
        public IfcPositiveLengthMeasure FrameDepth { get; set; } // optional
        public IfcPositiveLengthMeasure FrameThickness { get; set; } // optional
        public IfcShapeAspect ShapeAspectStyle { get; set; } // optional

        public new static IfcPermeableCoveringProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPermeableCoveringProperties>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                OperationType.ToStepValue(),
                PanelPosition.ToStepValue(),
                FrameDepth != null ? FrameDepth.ToStepValue() : "$",
                FrameThickness != null ? FrameThickness.ToStepValue() : "$",
                ShapeAspectStyle != null ? ShapeAspectStyle.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}