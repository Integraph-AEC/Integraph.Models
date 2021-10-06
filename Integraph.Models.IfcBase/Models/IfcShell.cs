namespace Integraph.Models.IfcBase.Models
{
    public class IfcShell : Select
    {
        public IfcShell(IfcClosedShell choice)
        {
            _choice = choice;
        }

        public IfcShell(IfcOpenShell choice)
        {
            _choice = choice;
        }
    }
}