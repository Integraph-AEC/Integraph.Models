namespace Integraph.Models.IfcBase.Models
{
    public class IfcTextFontSelect : Select
    {
        public IfcTextFontSelect(IfcExternallyDefinedTextFont choice)
        {
            _choice = choice;
        }

        public IfcTextFontSelect(IfcPreDefinedTextFont choice)
        {
            _choice = choice;
        }
    }
}