namespace Integraph.Models.IfcBase.Models
{
    public class IfcSpecularHighlightSelect : Select
    {
        public IfcSpecularHighlightSelect(IfcSpecularExponent choice)
        {
            _choice = choice;
        }

        public IfcSpecularHighlightSelect(IfcSpecularRoughness choice)
        {
            _choice = choice;
        }
    }
}