namespace Integraph.Models.IfcBase.Models
{
    public class IfcProductSelect : Select
    {
        public IfcProductSelect(IfcProduct choice)
        {
            _choice = choice;
        }

        public IfcProductSelect(IfcTypeProduct choice)
        {
            _choice = choice;
        }
    }
}