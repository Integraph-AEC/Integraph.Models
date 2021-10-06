namespace Integraph.Models.IfcBase.Models
{
    public class IfcSizeSelect : Select
    {
        public IfcSizeSelect(IfcDescriptiveMeasure choice)
        {
            _choice = choice;
        }

        public IfcSizeSelect(IfcLengthMeasure choice)
        {
            _choice = choice;
        }

        public IfcSizeSelect(IfcNormalisedRatioMeasure choice)
        {
            _choice = choice;
        }

        public IfcSizeSelect(IfcPositiveLengthMeasure choice)
        {
            _choice = choice;
        }

        public IfcSizeSelect(IfcPositiveRatioMeasure choice)
        {
            _choice = choice;
        }

        public IfcSizeSelect(IfcRatioMeasure choice)
        {
            _choice = choice;
        }
    }
}