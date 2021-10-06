namespace Integraph.Models.IfcBase.Models
{
    public class IfcColourOrFactor : Select
    {
        public IfcColourOrFactor(IfcColourRgb choice)
        {
            _choice = choice;
        }

        public IfcColourOrFactor(IfcNormalisedRatioMeasure choice)
        {
            _choice = choice;
        }
    }
}