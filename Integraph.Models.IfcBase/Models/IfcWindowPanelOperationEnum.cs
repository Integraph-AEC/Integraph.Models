namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcwindowpaneloperationenum.htm
	/// </summary>
	public enum IfcWindowPanelOperationEnum
    {
        SideHungRightHand,
        SideHungLeftHand,
        TiltAndTurnRightHand,
        TiltAndTurnLeftHand,
        TopHung,
        BottomHung,
        PivotHorizontal,
        PivotVertical,
        SlidingHorizontal,
        SlidingVertical,
        RemovableCasement,
        FixedCasement,
        OtherOperation,
        NotDefined
    }
}