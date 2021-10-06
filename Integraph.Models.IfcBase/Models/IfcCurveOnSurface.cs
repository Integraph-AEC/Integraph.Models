namespace Integraph.Models.IfcBase.Models
{
    public class IfcCurveOnSurface : Select
    {
        public IfcCurveOnSurface(IfcCompositeCurveOnSurface choice)
        {
            _choice = choice;
        }

        public IfcCurveOnSurface(IfcPcurve choice)
        {
            _choice = choice;
        }

        public IfcCurveOnSurface(IfcSurfaceCurve choice)
        {
            _choice = choice;
        }
    }
}