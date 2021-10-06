namespace Integraph.Models.IfcBase.Models
{
    public class IfcColour : Select
    {
        public IfcColour(IfcColourSpecification choice)
        {
            _choice = choice;
        }

        public IfcColour(IfcPreDefinedColour choice)
        {
            _choice = choice;
        }
    }
}