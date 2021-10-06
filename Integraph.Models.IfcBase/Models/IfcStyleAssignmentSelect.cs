namespace Integraph.Models.IfcBase.Models
{
    public class IfcStyleAssignmentSelect : Select
    {
        public IfcStyleAssignmentSelect(IfcPresentationStyle choice)
        {
            _choice = choice;
        }

        public IfcStyleAssignmentSelect(IfcPresentationStyleAssignment choice)
        {
            _choice = choice;
        }
    }
}