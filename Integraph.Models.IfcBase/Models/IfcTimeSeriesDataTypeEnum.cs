namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctimeseriesdatatypeenum.htm
	/// </summary>
	public enum IfcTimeSeriesDataTypeEnum
    {
        Continuous,
        Discrete,
        DiscreteBinary,
        PiecewiseBinary,
        PiecewiseConstant,
        PiecewiseContinuous,
        NotDefined
    }
}