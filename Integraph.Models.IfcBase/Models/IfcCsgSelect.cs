namespace Integraph.Models.IfcBase.Models
{
    public class IfcCsgSelect : Select
    {
        public IfcCsgSelect(IfcBooleanResult choice)
        {
            _choice = choice;
        }

        public IfcCsgSelect(IfcCsgPrimitive3D choice)
        {
            _choice = choice;
        }
    }
}