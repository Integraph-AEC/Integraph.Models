using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmateriallayerset.htm" />
	/// </summary>
	public class IfcMaterialLayerSet : IfcMaterialDefinition
    {
	    /// <summary>
	    ///     Construct a IfcMaterialLayerSet with all required attributes.
	    /// </summary>
	    public IfcMaterialLayerSet(List<IfcMaterialLayer> materialLayers)
        {
            MaterialLayers = materialLayers;
        }

	    /// <summary>
	    ///     Construct a IfcMaterialLayerSet with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialLayerSet(List<IfcMaterialLayer> materialLayers, IfcLabel layerSetName, IfcText description)
        {
            MaterialLayers = materialLayers;
            LayerSetName = layerSetName;
            Description = description;
        }

        public List<IfcMaterialLayer> MaterialLayers { get; set; }
        public IfcLabel LayerSetName { get; set; } // optional
        public IfcText Description { get; set; } // optional

        [JsonIgnore]
        public IfcLengthMeasure TotalThickness =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for TotalThickness."); // derived

        public new static IfcMaterialLayerSet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialLayerSet>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            MaterialLayers != null ? MaterialLayers.ToStepValue() : "$",
	            LayerSetName != null ? LayerSetName.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}