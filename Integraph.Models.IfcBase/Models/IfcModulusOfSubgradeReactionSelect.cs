namespace Integraph.Models.IfcBase.Models
{
    public class IfcModulusOfSubgradeReactionSelect : Select
    {
        public IfcModulusOfSubgradeReactionSelect(IfcBoolean choice)
        {
            _choice = choice;
        }

        public IfcModulusOfSubgradeReactionSelect(IfcModulusOfSubgradeReactionMeasure choice)
        {
            _choice = choice;
        }
    }
}