namespace Integraph.Models.IfcBase.Models
{
    public class IfcLibrarySelect : Select
    {
        public IfcLibrarySelect(IfcLibraryInformation choice)
        {
            _choice = choice;
        }

        public IfcLibrarySelect(IfcLibraryReference choice)
        {
            _choice = choice;
        }
    }
}