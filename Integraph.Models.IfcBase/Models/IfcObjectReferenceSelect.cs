namespace Integraph.Models.IfcBase.Models
{
    public class IfcObjectReferenceSelect : Select
    {
        public IfcObjectReferenceSelect(IfcAddress choice)
        {
            _choice = choice;
        }

        public IfcObjectReferenceSelect(IfcAppliedValue choice)
        {
            _choice = choice;
        }

        public IfcObjectReferenceSelect(IfcExternalReference choice)
        {
            _choice = choice;
        }

        public IfcObjectReferenceSelect(IfcMaterialDefinition choice)
        {
            _choice = choice;
        }

        public IfcObjectReferenceSelect(IfcOrganization choice)
        {
            _choice = choice;
        }

        public IfcObjectReferenceSelect(IfcPerson choice)
        {
            _choice = choice;
        }

        public IfcObjectReferenceSelect(IfcPersonAndOrganization choice)
        {
            _choice = choice;
        }

        public IfcObjectReferenceSelect(IfcTable choice)
        {
            _choice = choice;
        }

        public IfcObjectReferenceSelect(IfcTimeSeries choice)
        {
            _choice = choice;
        }
    }
}