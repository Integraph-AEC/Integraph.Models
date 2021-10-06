namespace Integraph.Models.IfcBase.Models
{
    public class IfcGeometricSetSelect : Select
    {
        public IfcGeometricSetSelect(IfcCurve choice)
        {
            _choice = choice;
        }

        public IfcGeometricSetSelect(IfcPoint choice)
        {
            _choice = choice;
        }

        public IfcGeometricSetSelect(IfcSurface choice)
        {
            _choice = choice;
        }
    }
}