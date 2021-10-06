namespace Integraph.Models.IfcBase.Models
{
    public class IfcStructuralActivityAssignmentSelect : Select
    {
        public IfcStructuralActivityAssignmentSelect(IfcElement choice)
        {
            _choice = choice;
        }

        public IfcStructuralActivityAssignmentSelect(IfcStructuralItem choice)
        {
            _choice = choice;
        }
    }
}