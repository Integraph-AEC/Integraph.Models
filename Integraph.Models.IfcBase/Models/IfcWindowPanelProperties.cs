using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcwindowpanelproperties.htm" />
	/// </summary>
	public class IfcWindowPanelProperties : IfcPreDefinedPropertySet
    {
	    /// <summary>
	    ///     Construct a IfcWindowPanelProperties with all required attributes.
	    /// </summary>
	    public IfcWindowPanelProperties(IfcGloballyUniqueId globalId, IfcWindowPanelOperationEnum operationType,
            IfcWindowPanelPositionEnum panelPosition) : base(globalId)
        {
            OperationType = operationType;
            PanelPosition = panelPosition;
        }

	    /// <summary>
	    ///     Construct a IfcWindowPanelProperties with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcWindowPanelProperties(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcWindowPanelOperationEnum operationType, IfcWindowPanelPositionEnum panelPosition,
            IfcPositiveLengthMeasure frameDepth, IfcPositiveLengthMeasure frameThickness,
            IfcShapeAspect shapeAspectStyle) : base(globalId, ownerHistory, name, description)
        {
            OperationType = operationType;
            PanelPosition = panelPosition;
            FrameDepth = frameDepth;
            FrameThickness = frameThickness;
            ShapeAspectStyle = shapeAspectStyle;
        }

        public IfcWindowPanelOperationEnum? OperationType { get; set; }
        public IfcWindowPanelPositionEnum? PanelPosition { get; set; }
        public IfcPositiveLengthMeasure FrameDepth { get; set; } // optional
        public IfcPositiveLengthMeasure FrameThickness { get; set; } // optional
        public IfcShapeAspect ShapeAspectStyle { get; set; } // optional

        public new static IfcWindowPanelProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcWindowPanelProperties>(json);
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