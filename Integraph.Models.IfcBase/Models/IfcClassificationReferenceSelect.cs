namespace Integraph.Models.IfcBase.Models
{
    public class IfcClassificationReferenceSelect : Select
    {
        public IfcClassificationReferenceSelect(IfcClassification choice)
        {
            _choice = choice;
        }

        public IfcClassificationReferenceSelect(IfcClassificationReference choice)
        {
            _choice = choice;
        }
    }
}