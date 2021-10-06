using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreinforcementbarproperties.htm" />
	/// </summary>
	public class IfcReinforcementBarProperties : IfcPreDefinedProperties
    {
	    /// <summary>
	    ///     Construct a IfcReinforcementBarProperties with all required attributes.
	    /// </summary>
	    public IfcReinforcementBarProperties(IfcAreaMeasure totalCrossSectionArea, IfcLabel steelGrade)
        {
            TotalCrossSectionArea = totalCrossSectionArea;
            SteelGrade = steelGrade;
        }

	    /// <summary>
	    ///     Construct a IfcReinforcementBarProperties with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcReinforcementBarProperties(IfcAreaMeasure totalCrossSectionArea, IfcLabel steelGrade,
            IfcReinforcingBarSurfaceEnum barSurface, IfcLengthMeasure effectiveDepth,
            IfcPositiveLengthMeasure nominalBarDiameter, IfcCountMeasure barCount)
        {
            TotalCrossSectionArea = totalCrossSectionArea;
            SteelGrade = steelGrade;
            BarSurface = barSurface;
            EffectiveDepth = effectiveDepth;
            NominalBarDiameter = nominalBarDiameter;
            BarCount = barCount;
        }

        public IfcAreaMeasure TotalCrossSectionArea { get; set; }
        public IfcLabel SteelGrade { get; set; }
        public IfcReinforcingBarSurfaceEnum? BarSurface { get; set; } // optional
        public IfcLengthMeasure EffectiveDepth { get; set; } // optional
        public IfcPositiveLengthMeasure NominalBarDiameter { get; set; } // optional
        public IfcCountMeasure BarCount { get; set; } // optional

        public new static IfcReinforcementBarProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcReinforcementBarProperties>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            TotalCrossSectionArea != null ? TotalCrossSectionArea.ToStepValue() : "$",
	            SteelGrade != null ? SteelGrade.ToStepValue() : "$",
	            BarSurface.ToStepValue(),
	            EffectiveDepth != null ? EffectiveDepth.ToStepValue() : "$",
	            NominalBarDiameter != null ? NominalBarDiameter.ToStepValue() : "$",
	            BarCount != null ? BarCount.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}