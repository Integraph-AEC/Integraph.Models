namespace Integraph.Models.IfcBase.Models
{
    public abstract class Select : BaseIfc
    {
        protected BaseIfc _choice;
        public BaseIfc Choice => _choice;

        public override string ToStepValue(bool isSelectOption = false)
        {
            {
                return _choice.ToStepValue(true);
            }
        }

        public override string ToStep()
        {
            {
                return $"#{_choice.StepId} = {_choice.GetType().Name.ToUpper()}({_choice.GetStepParameters()});";
            }
        }
    }
}