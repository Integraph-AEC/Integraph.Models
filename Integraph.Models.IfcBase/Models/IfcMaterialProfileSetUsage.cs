using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialprofilesetusage.htm" />
	/// </summary>
	public class IfcMaterialProfileSetUsage : IfcMaterialUsageDefinition
    {
	    /// <summary>
	    ///     Construct a IfcMaterialProfileSetUsage with all required attributes.
	    /// </summary>
	    public IfcMaterialProfileSetUsage(IfcMaterialProfileSet forProfileSet)
        {
            ForProfileSet = forProfileSet;
        }

	    /// <summary>
	    ///     Construct a IfcMaterialProfileSetUsage with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialProfileSetUsage(IfcMaterialProfileSet forProfileSet, IfcCardinalPointReference cardinalPoint,
            IfcPositiveLengthMeasure referenceExtent)
        {
            ForProfileSet = forProfileSet;
            CardinalPoint = cardinalPoint;
            ReferenceExtent = referenceExtent;
        }

        public IfcMaterialProfileSet ForProfileSet { get; set; }
        public IfcCardinalPointReference CardinalPoint { get; set; } // optional
        public IfcPositiveLengthMeasure ReferenceExtent { get; set; } // optional

        public new static IfcMaterialProfileSetUsage FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialProfileSetUsage>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            ForProfileSet != null ? ForProfileSet.ToStepValue() : "$",
	            CardinalPoint != null ? CardinalPoint.ToStepValue() : "$",
	            ReferenceExtent != null ? ReferenceExtent.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}