namespace Integraph.Models.IfcBase.Models
{
    public class IfcGridPlacementDirectionSelect : Select
    {
        public IfcGridPlacementDirectionSelect(IfcDirection choice)
        {
            _choice = choice;
        }

        public IfcGridPlacementDirectionSelect(IfcVirtualGridIntersection choice)
        {
            _choice = choice;
        }
    }
}