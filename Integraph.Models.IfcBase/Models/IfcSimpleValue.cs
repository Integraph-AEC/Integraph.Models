namespace Integraph.Models.IfcBase.Models
{
    public class IfcSimpleValue : Select
    {
        public IfcSimpleValue(IfcBinary choice)
        {
            _choice = choice;
        }

        public IfcSimpleValue(IfcBoolean choice)
        {
            _choice = choice;
        }

        public IfcSimpleValue(IfcDate choice)
        {
            _choice = choice;
        }

        public IfcSimpleValue(IfcDateTime choice)
        {
            _choice = choice;
        }

        public IfcSimpleValue(IfcDuration choice)
        {
            _choice = choice;
        }

        public IfcSimpleValue(IfcIdentifier choice)
        {
            _choice = choice;
        }

        public IfcSimpleValue(IfcInteger choice)
        {
            _choice = choice;
        }

        public IfcSimpleValue(IfcLabel choice)
        {
            _choice = choice;
        }

        public IfcSimpleValue(IfcLogical choice)
        {
            _choice = choice;
        }

        public IfcSimpleValue(IfcPositiveInteger choice)
        {
            _choice = choice;
        }

        public IfcSimpleValue(IfcReal choice)
        {
            _choice = choice;
        }

        public IfcSimpleValue(IfcText choice)
        {
            _choice = choice;
        }

        public IfcSimpleValue(IfcTime choice)
        {
            _choice = choice;
        }

        public IfcSimpleValue(IfcTimeStamp choice)
        {
            _choice = choice;
        }
    }
}