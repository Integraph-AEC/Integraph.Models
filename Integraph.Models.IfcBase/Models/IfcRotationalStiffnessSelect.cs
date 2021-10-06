namespace Integraph.Models.IfcBase.Models
{
    public class IfcRotationalStiffnessSelect : Select
    {
        public IfcRotationalStiffnessSelect(IfcBoolean choice)
        {
            _choice = choice;
        }

        public IfcRotationalStiffnessSelect(IfcRotationalStiffnessMeasure choice)
        {
            _choice = choice;
        }
    }
}