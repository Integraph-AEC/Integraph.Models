namespace Integraph.Models.IfcBase.Models
{
    public class IfcSegmentIndexSelect : Select
    {
        public IfcSegmentIndexSelect(IfcArcIndex choice)
        {
            _choice = choice;
        }

        public IfcSegmentIndexSelect(IfcLineIndex choice)
        {
            _choice = choice;
        }
    }
}