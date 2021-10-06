using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmateriallayer.htm" />
	/// </summary>
	public class IfcMaterialLayer : IfcMaterialDefinition
    {
	    /// <summary>
	    ///     Construct a IfcMaterialLayer with all required attributes.
	    /// </summary>
	    public IfcMaterialLayer(IfcNonNegativeLengthMeasure layerThickness)
        {
            LayerThickness = layerThickness;
        }

	    /// <summary>
	    ///     Construct a IfcMaterialLayer with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialLayer(IfcMaterial material, IfcNonNegativeLengthMeasure layerThickness,
            IfcLogical isVentilated, IfcLabel name, IfcText description, IfcLabel category, IfcInteger priority)
        {
            Material = material;
            LayerThickness = layerThickness;
            IsVentilated = isVentilated;
            Name = name;
            Description = description;
            Category = category;
            Priority = priority;
        }

        public IfcMaterial Material { get; set; } // optional
        public IfcNonNegativeLengthMeasure LayerThickness { get; set; }
        public IfcLogical IsVentilated { get; set; } // optional
        public IfcLabel Name { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public IfcLabel Category { get; set; } // optional
        public IfcInteger Priority { get; set; } // optional
        public IfcMaterialLayerSet ToMaterialLayerSet { get; set; } // inverse

        public new static IfcMaterialLayer FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialLayer>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Material != null ? Material.ToStepValue() : "$",
	            LayerThickness != null ? LayerThickness.ToStepValue() : "$",
	            IsVentilated != null ? IsVentilated.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Category != null ? Category.ToStepValue() : "$",
	            Priority != null ? Priority.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}