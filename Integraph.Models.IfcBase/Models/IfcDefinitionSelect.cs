namespace Integraph.Models.IfcBase.Models
{
    public class IfcDefinitionSelect : Select
    {
        public IfcDefinitionSelect(IfcObjectDefinition choice)
        {
            _choice = choice;
        }

        public IfcDefinitionSelect(IfcPropertyDefinition choice)
        {
            _choice = choice;
        }
    }
}