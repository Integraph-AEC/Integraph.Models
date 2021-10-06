namespace Integraph.Models.IfcBase.Models
{
    public class IfcProcessSelect : Select
    {
        public IfcProcessSelect(IfcProcess choice)
        {
            _choice = choice;
        }

        public IfcProcessSelect(IfcTypeProcess choice)
        {
            _choice = choice;
        }
    }
}