namespace Integraph.Models.IfcBase.Models
{
    public class IfcMaterialSelect : Select
    {
        public IfcMaterialSelect(IfcMaterialDefinition choice)
        {
            _choice = choice;
        }

        public IfcMaterialSelect(IfcMaterialList choice)
        {
            _choice = choice;
        }

        public IfcMaterialSelect(IfcMaterialUsageDefinition choice)
        {
            _choice = choice;
        }
    }
}