using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdoorpanelproperties.htm" />
	/// </summary>
	public class IfcDoorPanelProperties : IfcPreDefinedPropertySet
    {
	    /// <summary>
	    ///     Construct a IfcDoorPanelProperties with all required attributes.
	    /// </summary>
	    public IfcDoorPanelProperties(IfcGloballyUniqueId globalId, IfcDoorPanelOperationEnum panelOperation,
            IfcDoorPanelPositionEnum panelPosition) : base(globalId)
        {
            PanelOperation = panelOperation;
            PanelPosition = panelPosition;
        }

	    /// <summary>
	    ///     Construct a IfcDoorPanelProperties with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDoorPanelProperties(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcPositiveLengthMeasure panelDepth, IfcDoorPanelOperationEnum panelOperation,
            IfcNormalisedRatioMeasure panelWidth, IfcDoorPanelPositionEnum panelPosition,
            IfcShapeAspect shapeAspectStyle) : base(globalId, ownerHistory, name, description)
        {
            PanelDepth = panelDepth;
            PanelOperation = panelOperation;
            PanelWidth = panelWidth;
            PanelPosition = panelPosition;
            ShapeAspectStyle = shapeAspectStyle;
        }

        public IfcPositiveLengthMeasure PanelDepth { get; set; } // optional
        public IfcDoorPanelOperationEnum? PanelOperation { get; set; }
        public IfcNormalisedRatioMeasure PanelWidth { get; set; } // optional
        public IfcDoorPanelPositionEnum? PanelPosition { get; set; }
        public IfcShapeAspect ShapeAspectStyle { get; set; } // optional

        public new static IfcDoorPanelProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDoorPanelProperties>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                PanelDepth != null ? PanelDepth.ToStepValue() : "$",
                PanelOperation.ToStepValue(),
                PanelWidth != null ? PanelWidth.ToStepValue() : "$",
                PanelPosition.ToStepValue(),
                ShapeAspectStyle != null ? ShapeAspectStyle.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}