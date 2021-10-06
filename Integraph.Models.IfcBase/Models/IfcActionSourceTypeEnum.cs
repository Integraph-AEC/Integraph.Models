namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcactionsourcetypeenum.htm
	/// </summary>
	public enum IfcActionSourceTypeEnum
    {
        DeadLoadG,
        CompletionG1,
        LiveLoadQ,
        SnowS,
        WindW,
        PrestressingP,
        SettlementU,
        TemperatureT,
        EarthquakeE,
        Fire,
        Impulse,
        Impact,
        Transport,
        Erection,
        Propping,
        SystemImperfection,
        Shrinkage,
        Creep,
        LackOfFit,
        Buoyancy,
        Ice,
        Current,
        Wave,
        Rain,
        Brakes,
        UserDefined,
        NotDefined
    }
}