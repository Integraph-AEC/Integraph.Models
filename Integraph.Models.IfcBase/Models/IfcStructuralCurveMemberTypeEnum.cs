namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralcurvemembertypeenum.htm
	/// </summary>
	public enum IfcStructuralCurveMemberTypeEnum
    {
        RigidJoinedMember,
        PinJoinedMember,
        Cable,
        TensionMember,
        CompressionMember,
        UserDefined,
        NotDefined
    }
}