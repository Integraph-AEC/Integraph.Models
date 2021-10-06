namespace Integraph.Models.IfcBase.Models
{
    public class IfcClassificationSelect : Select
    {
        public IfcClassificationSelect(IfcClassification choice)
        {
            _choice = choice;
        }

        public IfcClassificationSelect(IfcClassificationReference choice)
        {
            _choice = choice;
        }
    }
}