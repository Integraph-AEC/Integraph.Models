namespace Integraph.Models.IfcBase.Models
{
    public class IfcTranslationalStiffnessSelect : Select
    {
        public IfcTranslationalStiffnessSelect(IfcBoolean choice)
        {
            _choice = choice;
        }

        public IfcTranslationalStiffnessSelect(IfcLinearStiffnessMeasure choice)
        {
            _choice = choice;
        }
    }
}