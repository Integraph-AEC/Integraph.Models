namespace Integraph.Models.IfcBase.Models
{
    public class IfcActorSelect : Select
    {
        public IfcActorSelect(IfcOrganization choice)
        {
            _choice = choice;
        }

        public IfcActorSelect(IfcPerson choice)
        {
            _choice = choice;
        }

        public IfcActorSelect(IfcPersonAndOrganization choice)
        {
            _choice = choice;
        }
    }
}