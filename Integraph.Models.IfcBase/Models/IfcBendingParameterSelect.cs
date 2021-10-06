namespace Integraph.Models.IfcBase.Models
{
    public class IfcBendingParameterSelect : Select
    {
        public IfcBendingParameterSelect(IfcLengthMeasure choice)
        {
            _choice = choice;
        }

        public IfcBendingParameterSelect(IfcPlaneAngleMeasure choice)
        {
            _choice = choice;
        }
    }
}