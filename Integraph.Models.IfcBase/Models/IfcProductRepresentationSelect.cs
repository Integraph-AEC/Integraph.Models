namespace Integraph.Models.IfcBase.Models
{
    public class IfcProductRepresentationSelect : Select
    {
        public IfcProductRepresentationSelect(IfcProductDefinitionShape choice)
        {
            _choice = choice;
        }

        public IfcProductRepresentationSelect(IfcRepresentationMap choice)
        {
            _choice = choice;
        }
    }
}