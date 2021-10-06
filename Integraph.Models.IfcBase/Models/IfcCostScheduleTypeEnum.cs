namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccostscheduletypeenum.htm
	/// </summary>
	public enum IfcCostScheduleTypeEnum
    {
        Budget,
        Costplan,
        Estimate,
        Tender,
        Pricedbillofquantities,
        Unpricedbillofquantities,
        Scheduleofrates,
        UserDefined,
        NotDefined
    }
}