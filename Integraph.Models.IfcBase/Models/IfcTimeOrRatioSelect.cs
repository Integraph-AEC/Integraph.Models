namespace Integraph.Models.IfcBase.Models
{
    public class IfcTimeOrRatioSelect : Select
    {
        public IfcTimeOrRatioSelect(IfcDuration choice)
        {
            _choice = choice;
        }

        public IfcTimeOrRatioSelect(IfcRatioMeasure choice)
        {
            _choice = choice;
        }
    }
}