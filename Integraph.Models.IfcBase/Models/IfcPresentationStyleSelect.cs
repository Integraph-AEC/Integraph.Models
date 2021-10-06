namespace Integraph.Models.IfcBase.Models
{
    public class IfcPresentationStyleSelect : Select
    {
        public IfcPresentationStyleSelect(IfcCurveStyle choice)
        {
            _choice = choice;
        }

        public IfcPresentationStyleSelect(IfcFillAreaStyle choice)
        {
            _choice = choice;
        }

        public IfcPresentationStyleSelect(IfcSurfaceStyle choice)
        {
            _choice = choice;
        }

        public IfcPresentationStyleSelect(IfcTextStyle choice)
        {
            _choice = choice;
        }
    }
}