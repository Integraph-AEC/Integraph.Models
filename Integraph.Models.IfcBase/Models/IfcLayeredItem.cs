namespace Integraph.Models.IfcBase.Models
{
    public class IfcLayeredItem : Select
    {
        public IfcLayeredItem(IfcRepresentation choice)
        {
            _choice = choice;
        }

        public IfcLayeredItem(IfcRepresentationItem choice)
        {
            _choice = choice;
        }
    }
}