namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrecurrencetypeenum.htm
	/// </summary>
	public enum IfcRecurrenceTypeEnum
    {
        Daily,
        Weekly,
        MonthlyByDayOfMonth,
        MonthlyByPosition,
        ByDayCount,
        ByWeekdayCount,
        YearlyByDayOfMonth,
        YearlyByPosition
    }
}