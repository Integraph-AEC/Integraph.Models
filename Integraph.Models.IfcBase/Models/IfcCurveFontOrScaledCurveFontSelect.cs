namespace Integraph.Models.IfcBase.Models
{
    public class IfcCurveFontOrScaledCurveFontSelect : Select
    {
        public IfcCurveFontOrScaledCurveFontSelect(IfcCurveStyleFontAndScaling choice)
        {
            _choice = choice;
        }

        public IfcCurveFontOrScaledCurveFontSelect(IfcCurveStyleFontSelect choice)
        {
            _choice = choice;
        }
    }
}