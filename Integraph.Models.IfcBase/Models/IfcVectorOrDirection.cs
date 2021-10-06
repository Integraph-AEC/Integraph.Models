namespace Integraph.Models.IfcBase.Models
{
    public class IfcVectorOrDirection : Select
    {
        public IfcVectorOrDirection(IfcDirection choice)
        {
            _choice = choice;
        }

        public IfcVectorOrDirection(IfcVector choice)
        {
            _choice = choice;
        }
    }
}