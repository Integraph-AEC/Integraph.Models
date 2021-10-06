namespace Integraph.Models.IfcBase.Models
{
    public class IfcBooleanOperand : Select
    {
        public IfcBooleanOperand(IfcBooleanResult choice)
        {
            _choice = choice;
        }

        public IfcBooleanOperand(IfcCsgPrimitive3D choice)
        {
            _choice = choice;
        }

        public IfcBooleanOperand(IfcHalfSpaceSolid choice)
        {
            _choice = choice;
        }

        public IfcBooleanOperand(IfcSolidModel choice)
        {
            _choice = choice;
        }

        public IfcBooleanOperand(IfcTessellatedFaceSet choice)
        {
            _choice = choice;
        }
    }
}