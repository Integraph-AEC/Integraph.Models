namespace Integraph.Models.IfcBase.Models
{
    public class IfcCurveStyleFontSelect : Select
    {
        public IfcCurveStyleFontSelect(IfcCurveStyleFont choice)
        {
            _choice = choice;
        }

        public IfcCurveStyleFontSelect(IfcPreDefinedCurveFont choice)
        {
            _choice = choice;
        }
    }
}