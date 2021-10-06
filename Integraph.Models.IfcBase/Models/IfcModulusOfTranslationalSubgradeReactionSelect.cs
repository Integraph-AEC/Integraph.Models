namespace Integraph.Models.IfcBase.Models
{
    public class IfcModulusOfTranslationalSubgradeReactionSelect : Select
    {
        public IfcModulusOfTranslationalSubgradeReactionSelect(IfcBoolean choice)
        {
            _choice = choice;
        }

        public IfcModulusOfTranslationalSubgradeReactionSelect(IfcModulusOfLinearSubgradeReactionMeasure choice)
        {
            _choice = choice;
        }
    }
}