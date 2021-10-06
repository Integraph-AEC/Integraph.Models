using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmateriallayersetusage.htm" />
	/// </summary>
	public class IfcMaterialLayerSetUsage : IfcMaterialUsageDefinition
    {
	    /// <summary>
	    ///     Construct a IfcMaterialLayerSetUsage with all required attributes.
	    /// </summary>
	    public IfcMaterialLayerSetUsage(IfcMaterialLayerSet forLayerSet, IfcLayerSetDirectionEnum layerSetDirection,
            IfcDirectionSenseEnum directionSense, IfcLengthMeasure offsetFromReferenceLine)
        {
            ForLayerSet = forLayerSet;
            LayerSetDirection = layerSetDirection;
            DirectionSense = directionSense;
            OffsetFromReferenceLine = offsetFromReferenceLine;
        }

	    /// <summary>
	    ///     Construct a IfcMaterialLayerSetUsage with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialLayerSetUsage(IfcMaterialLayerSet forLayerSet, IfcLayerSetDirectionEnum layerSetDirection,
            IfcDirectionSenseEnum directionSense, IfcLengthMeasure offsetFromReferenceLine,
            IfcPositiveLengthMeasure referenceExtent)
        {
            ForLayerSet = forLayerSet;
            LayerSetDirection = layerSetDirection;
            DirectionSense = directionSense;
            OffsetFromReferenceLine = offsetFromReferenceLine;
            ReferenceExtent = referenceExtent;
        }

        public IfcMaterialLayerSet ForLayerSet { get; set; }
        public IfcLayerSetDirectionEnum? LayerSetDirection { get; set; }
        public IfcDirectionSenseEnum? DirectionSense { get; set; }
        public IfcLengthMeasure OffsetFromReferenceLine { get; set; }
        public IfcPositiveLengthMeasure ReferenceExtent { get; set; } // optional

        public new static IfcMaterialLayerSetUsage FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialLayerSetUsage>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ForLayerSet != null ? ForLayerSet.ToStepValue() : "$",
                LayerSetDirection.ToStepValue(),
                DirectionSense.ToStepValue(),
                OffsetFromReferenceLine != null ? OffsetFromReferenceLine.ToStepValue() : "$",
                ReferenceExtent != null ? ReferenceExtent.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}