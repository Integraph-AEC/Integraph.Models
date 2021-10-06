namespace Integraph.Models.IfcBase.Models
{
    public class IfcAxis2Placement : Select
    {
        public IfcAxis2Placement(IfcAxis2Placement2D choice)
        {
            _choice = choice;
        }

        public IfcAxis2Placement(IfcAxis2Placement3D choice)
        {
            _choice = choice;
        }
    }
}