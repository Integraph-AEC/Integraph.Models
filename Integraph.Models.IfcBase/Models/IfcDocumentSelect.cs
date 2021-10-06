namespace Integraph.Models.IfcBase.Models
{
    public class IfcDocumentSelect : Select
    {
        public IfcDocumentSelect(IfcDocumentInformation choice)
        {
            _choice = choice;
        }

        public IfcDocumentSelect(IfcDocumentReference choice)
        {
            _choice = choice;
        }
    }
}