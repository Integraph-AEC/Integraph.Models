namespace Integraph.Models.IfcBase.Models
{
    public class IfcMetricValueSelect : Select
    {
        public IfcMetricValueSelect(IfcAppliedValue choice)
        {
            _choice = choice;
        }

        public IfcMetricValueSelect(IfcMeasureWithUnit choice)
        {
            _choice = choice;
        }

        public IfcMetricValueSelect(IfcReference choice)
        {
            _choice = choice;
        }

        public IfcMetricValueSelect(IfcTable choice)
        {
            _choice = choice;
        }

        public IfcMetricValueSelect(IfcTimeSeries choice)
        {
            _choice = choice;
        }

        public IfcMetricValueSelect(IfcValue choice)
        {
            _choice = choice;
        }
    }
}