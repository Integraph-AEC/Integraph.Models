namespace Integraph.Models.IfcBase.STEP
{
    public interface IConvertibleToStep
    {
        string ToStepValue(bool isSelectOption = false);
    }
}