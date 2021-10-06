namespace Integraph.Models.IfcBase.Models
{
    public class IfcPropertySetDefinitionSelect : Select
    {
        public IfcPropertySetDefinitionSelect(IfcPropertySetDefinition choice)
        {
            _choice = choice;
        }

        public IfcPropertySetDefinitionSelect(IfcPropertySetDefinitionSet choice)
        {
            _choice = choice;
        }
    }
}