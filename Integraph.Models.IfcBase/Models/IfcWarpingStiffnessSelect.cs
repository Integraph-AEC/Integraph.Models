namespace Integraph.Models.IfcBase.Models
{
    public class IfcWarpingStiffnessSelect : Select
    {
        public IfcWarpingStiffnessSelect(IfcBoolean choice)
        {
            _choice = choice;
        }

        public IfcWarpingStiffnessSelect(IfcWarpingMomentMeasure choice)
        {
            _choice = choice;
        }
    }
}