namespace Integraph.Models.IfcBase.Models
{
    public class IfcSolidOrShell : Select
    {
        public IfcSolidOrShell(IfcClosedShell choice)
        {
            _choice = choice;
        }

        public IfcSolidOrShell(IfcSolidModel choice)
        {
            _choice = choice;
        }
    }
}