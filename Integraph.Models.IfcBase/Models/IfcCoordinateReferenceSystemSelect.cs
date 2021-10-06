namespace Integraph.Models.IfcBase.Models
{
    public class IfcCoordinateReferenceSystemSelect : Select
    {
        public IfcCoordinateReferenceSystemSelect(IfcCoordinateReferenceSystem choice)
        {
            _choice = choice;
        }

        public IfcCoordinateReferenceSystemSelect(IfcGeometricRepresentationContext choice)
        {
            _choice = choice;
        }
    }
}