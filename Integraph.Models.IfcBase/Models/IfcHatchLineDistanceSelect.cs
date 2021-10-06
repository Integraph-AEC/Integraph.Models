namespace Integraph.Models.IfcBase.Models
{
    public class IfcHatchLineDistanceSelect : Select
    {
        public IfcHatchLineDistanceSelect(IfcPositiveLengthMeasure choice)
        {
            _choice = choice;
        }

        public IfcHatchLineDistanceSelect(IfcVector choice)
        {
            _choice = choice;
        }
    }
}