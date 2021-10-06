using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmateriallayerwithoffsets.htm" />
	/// </summary>
	public class IfcMaterialLayerWithOffsets : IfcMaterialLayer
    {
	    /// <summary>
	    ///     Construct a IfcMaterialLayerWithOffsets with all required attributes.
	    /// </summary>
	    public IfcMaterialLayerWithOffsets(IfcNonNegativeLengthMeasure layerThickness,
            IfcLayerSetDirectionEnum offsetDirection, List<IfcLengthMeasure> offsetValues) : base(layerThickness)
        {
            OffsetDirection = offsetDirection;
            OffsetValues = offsetValues;
        }

	    /// <summary>
	    ///     Construct a IfcMaterialLayerWithOffsets with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialLayerWithOffsets(IfcMaterial material, IfcNonNegativeLengthMeasure layerThickness,
            IfcLogical isVentilated, IfcLabel name, IfcText description, IfcLabel category, IfcInteger priority,
            IfcLayerSetDirectionEnum offsetDirection, List<IfcLengthMeasure> offsetValues) : base(material,
            layerThickness, isVentilated, name, description, category, priority)
        {
            OffsetDirection = offsetDirection;
            OffsetValues = offsetValues;
        }

        public IfcLayerSetDirectionEnum? OffsetDirection { get; set; }
        public List<IfcLengthMeasure> OffsetValues { get; set; }

        public new static IfcMaterialLayerWithOffsets FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialLayerWithOffsets>(json);
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
                Priority != null ? Priority.ToStepValue() : "$",
                OffsetDirection.ToStepValue(),
                OffsetValues != null ? OffsetValues.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}