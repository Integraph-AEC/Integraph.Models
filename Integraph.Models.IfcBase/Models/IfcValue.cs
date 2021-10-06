namespace Integraph.Models.IfcBase.Models
{
    public class IfcValue : Select
    {
        public IfcValue(IfcDerivedMeasureValue choice)
        {
            _choice = choice;
        }

        public IfcValue(IfcMeasureValue choice)
        {
            _choice = choice;
        }

        public IfcValue(IfcSimpleValue choice)
        {
            _choice = choice;
        }
    }
}