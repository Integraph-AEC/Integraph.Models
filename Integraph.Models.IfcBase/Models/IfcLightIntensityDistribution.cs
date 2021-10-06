using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclightintensitydistribution.htm" />
	/// </summary>
	public class IfcLightIntensityDistribution : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcLightIntensityDistribution with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLightIntensityDistribution(IfcLightDistributionCurveEnum lightDistributionCurve,
            List<IfcLightDistributionData> distributionData)
        {
            LightDistributionCurve = lightDistributionCurve;
            DistributionData = distributionData;
        }

        public IfcLightDistributionCurveEnum? LightDistributionCurve { get; set; }
        public List<IfcLightDistributionData> DistributionData { get; set; }

        public static IfcLightIntensityDistribution FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLightIntensityDistribution>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                LightDistributionCurve.ToStepValue(),
                DistributionData != null ? DistributionData.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}