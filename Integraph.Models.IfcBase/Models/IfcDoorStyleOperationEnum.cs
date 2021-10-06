namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdoorstyleoperationenum.htm
	/// </summary>
	public enum IfcDoorStyleOperationEnum
    {
        SingleSwingLeft,
        SingleSwingRight,
        DoubleDoorSingleSwing,
        DoubleDoorSingleSwingOppositeLeft,
        DoubleDoorSingleSwingOppositeRight,
        DoubleSwingLeft,
        DoubleSwingRight,
        DoubleDoorDoubleSwing,
        SlidingToLeft,
        SlidingToRight,
        DoubleDoorSliding,
        FoldingToLeft,
        FoldingToRight,
        DoubleDoorFolding,
        Revolving,
        Rollingup,
        UserDefined,
        NotDefined
    }
}