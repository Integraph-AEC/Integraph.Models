using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclightdistributiondata.htm" />
	/// </summary>
	public class IfcLightDistributionData : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcLightDistributionData with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLightDistributionData(IfcPlaneAngleMeasure mainPlaneAngle,
            List<IfcPlaneAngleMeasure> secondaryPlaneAngle,
            List<IfcLuminousIntensityDistributionMeasure> luminousIntensity)
        {
            MainPlaneAngle = mainPlaneAngle;
            SecondaryPlaneAngle = secondaryPlaneAngle;
            LuminousIntensity = luminousIntensity;
        }

        public IfcPlaneAngleMeasure MainPlaneAngle { get; set; }
        public List<IfcPlaneAngleMeasure> SecondaryPlaneAngle { get; set; }
        public List<IfcLuminousIntensityDistributionMeasure> LuminousIntensity { get; set; }

        public static IfcLightDistributionData FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLightDistributionData>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                MainPlaneAngle != null ? MainPlaneAngle.ToStepValue() : "$",
                SecondaryPlaneAngle != null ? SecondaryPlaneAngle.ToStepValue() : "$",
                LuminousIntensity != null ? LuminousIntensity.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}