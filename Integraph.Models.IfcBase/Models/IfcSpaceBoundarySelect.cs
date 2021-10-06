namespace Integraph.Models.IfcBase.Models
{
    public class IfcSpaceBoundarySelect : Select
    {
        public IfcSpaceBoundarySelect(IfcExternalSpatialElement choice)
        {
            _choice = choice;
        }

        public IfcSpaceBoundarySelect(IfcSpace choice)
        {
            _choice = choice;
        }
    }
}