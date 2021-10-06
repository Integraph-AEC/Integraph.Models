namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsequenceenum.htm
	/// </summary>
	public enum IfcSequenceEnum
    {
        StartStart,
        StartFinish,
        FinishStart,
        FinishFinish,
        UserDefined,
        NotDefined
    }
}