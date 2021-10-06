namespace Integraph.Models.IfcBase.Models
{
    public class IfcTrimmingSelect : Select
    {
        public IfcTrimmingSelect(IfcCartesianPoint choice)
        {
            _choice = choice;
        }

        public IfcTrimmingSelect(IfcParameterValue choice)
        {
            _choice = choice;
        }
    }
}