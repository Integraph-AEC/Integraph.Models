namespace Integraph.Models.IfcBase.Models
{
    public class IfcLightDistributionDataSourceSelect : Select
    {
        public IfcLightDistributionDataSourceSelect(IfcExternalReference choice)
        {
            _choice = choice;
        }

        public IfcLightDistributionDataSourceSelect(IfcLightIntensityDistribution choice)
        {
            _choice = choice;
        }
    }
}