using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpresentationlayerwithstyle.htm" />
	/// </summary>
	public class IfcPresentationLayerWithStyle : IfcPresentationLayerAssignment
    {
	    /// <summary>
	    ///     Construct a IfcPresentationLayerWithStyle with all required attributes.
	    /// </summary>
	    public IfcPresentationLayerWithStyle(IfcLabel name, List<IfcLayeredItem> assignedItems, IfcLogical layerOn,
            IfcLogical layerFrozen, IfcLogical layerBlocked, List<IfcPresentationStyle> layerStyles) : base(name,
            assignedItems)
        {
            LayerOn = layerOn;
            LayerFrozen = layerFrozen;
            LayerBlocked = layerBlocked;
            LayerStyles = layerStyles;
        }

	    /// <summary>
	    ///     Construct a IfcPresentationLayerWithStyle with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPresentationLayerWithStyle(IfcLabel name, IfcText description, List<IfcLayeredItem> assignedItems,
            IfcIdentifier identifier, IfcLogical layerOn, IfcLogical layerFrozen, IfcLogical layerBlocked,
            List<IfcPresentationStyle> layerStyles) : base(name, description, assignedItems, identifier)
        {
            LayerOn = layerOn;
            LayerFrozen = layerFrozen;
            LayerBlocked = layerBlocked;
            LayerStyles = layerStyles;
        }

        public IfcLogical LayerOn { get; set; }
        public IfcLogical LayerFrozen { get; set; }
        public IfcLogical LayerBlocked { get; set; }
        public List<IfcPresentationStyle> LayerStyles { get; set; }

        public new static IfcPresentationLayerWithStyle FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPresentationLayerWithStyle>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                AssignedItems != null ? AssignedItems.ToStepValue() : "$",
                Identifier != null ? Identifier.ToStepValue() : "$",
                LayerOn != null ? LayerOn.ToStepValue() : "$",
                LayerFrozen != null ? LayerFrozen.ToStepValue() : "$",
                LayerBlocked != null ? LayerBlocked.ToStepValue() : "$",
                LayerStyles != null ? LayerStyles.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}