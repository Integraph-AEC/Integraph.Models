namespace Integraph.Models.IfcBase.Models
{
    public class IfcAppliedValueSelect : Select
    {
        public IfcAppliedValueSelect(IfcMeasureWithUnit choice)
        {
            _choice = choice;
        }

        public IfcAppliedValueSelect(IfcReference choice)
        {
            _choice = choice;
        }

        public IfcAppliedValueSelect(IfcValue choice)
        {
            _choice = choice;
        }
    }
}