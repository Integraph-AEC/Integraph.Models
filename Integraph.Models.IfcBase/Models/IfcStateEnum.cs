namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstateenum.htm
	/// </summary>
	public enum IfcStateEnum
    {
        Readwrite,
        Readonly,
        Locked,
        Readwritelocked,
        Readonlylocked
    }
}