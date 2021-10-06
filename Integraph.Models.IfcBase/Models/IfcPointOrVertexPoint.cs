namespace Integraph.Models.IfcBase.Models
{
    public class IfcPointOrVertexPoint : Select
    {
        public IfcPointOrVertexPoint(IfcPoint choice)
        {
            _choice = choice;
        }

        public IfcPointOrVertexPoint(IfcVertexPoint choice)
        {
            _choice = choice;
        }
    }
}