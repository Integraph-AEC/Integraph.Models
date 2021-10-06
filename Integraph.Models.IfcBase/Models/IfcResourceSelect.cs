namespace Integraph.Models.IfcBase.Models
{
    public class IfcResourceSelect : Select
    {
        public IfcResourceSelect(IfcResource choice)
        {
            _choice = choice;
        }

        public IfcResourceSelect(IfcTypeResource choice)
        {
            _choice = choice;
        }
    }
}