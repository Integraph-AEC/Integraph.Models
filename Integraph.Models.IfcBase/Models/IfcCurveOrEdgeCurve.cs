namespace Integraph.Models.IfcBase.Models
{
    public class IfcCurveOrEdgeCurve : Select
    {
        public IfcCurveOrEdgeCurve(IfcBoundedCurve choice)
        {
            _choice = choice;
        }

        public IfcCurveOrEdgeCurve(IfcEdgeCurve choice)
        {
            _choice = choice;
        }
    }
}