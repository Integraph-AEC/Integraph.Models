namespace Integraph.Models.IfcBase.Models
{
    public class IfcModulusOfRotationalSubgradeReactionSelect : Select
    {
        public IfcModulusOfRotationalSubgradeReactionSelect(IfcBoolean choice)
        {
            _choice = choice;
        }

        public IfcModulusOfRotationalSubgradeReactionSelect(IfcModulusOfRotationalSubgradeReactionMeasure choice)
        {
            _choice = choice;
        }
    }
}