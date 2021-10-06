namespace Integraph.Models.IfcBase.Models
{
    public class IfcFillStyleSelect : Select
    {
        public IfcFillStyleSelect(IfcColour choice)
        {
            _choice = choice;
        }

        public IfcFillStyleSelect(IfcExternallyDefinedHatchStyle choice)
        {
            _choice = choice;
        }

        public IfcFillStyleSelect(IfcFillAreaStyleHatching choice)
        {
            _choice = choice;
        }

        public IfcFillStyleSelect(IfcFillAreaStyleTiles choice)
        {
            _choice = choice;
        }
    }
}