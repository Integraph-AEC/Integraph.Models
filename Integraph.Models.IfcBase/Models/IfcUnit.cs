namespace Integraph.Models.IfcBase.Models
{
    public class IfcUnit : Select
    {
        public IfcUnit(IfcDerivedUnit choice)
        {
            _choice = choice;
        }

        public IfcUnit(IfcMonetaryUnit choice)
        {
            _choice = choice;
        }

        public IfcUnit(IfcNamedUnit choice)
        {
            _choice = choice;
        }
    }
}