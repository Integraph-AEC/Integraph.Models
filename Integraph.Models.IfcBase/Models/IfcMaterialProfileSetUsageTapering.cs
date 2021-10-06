using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialprofilesetusagetapering.htm" />
	/// </summary>
	public class IfcMaterialProfileSetUsageTapering : IfcMaterialProfileSetUsage
    {
	    /// <summary>
	    ///     Construct a IfcMaterialProfileSetUsageTapering with all required attributes.
	    /// </summary>
	    public IfcMaterialProfileSetUsageTapering(IfcMaterialProfileSet forProfileSet,
            IfcMaterialProfileSet forProfileEndSet) : base(forProfileSet)
        {
            ForProfileEndSet = forProfileEndSet;
        }

	    /// <summary>
	    ///     Construct a IfcMaterialProfileSetUsageTapering with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialProfileSetUsageTapering(IfcMaterialProfileSet forProfileSet,
            IfcCardinalPointReference cardinalPoint, IfcPositiveLengthMeasure referenceExtent,
            IfcMaterialProfileSet forProfileEndSet, IfcCardinalPointReference cardinalEndPoint) : base(forProfileSet,
            cardinalPoint, referenceExtent)
        {
            ForProfileEndSet = forProfileEndSet;
            CardinalEndPoint = cardinalEndPoint;
        }

        public IfcMaterialProfileSet ForProfileEndSet { get; set; }
        public IfcCardinalPointReference CardinalEndPoint { get; set; } // optional

        public new static IfcMaterialProfileSetUsageTapering FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialProfileSetUsageTapering>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ForProfileSet != null ? ForProfileSet.ToStepValue() : "$",
                CardinalPoint != null ? CardinalPoint.ToStepValue() : "$",
                ReferenceExtent != null ? ReferenceExtent.ToStepValue() : "$",
                ForProfileEndSet != null ? ForProfileEndSet.ToStepValue() : "$",
                CardinalEndPoint != null ? CardinalEndPoint.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}