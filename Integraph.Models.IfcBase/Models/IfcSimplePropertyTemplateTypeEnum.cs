namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsimplepropertytemplatetypeenum.htm
	/// </summary>
	public enum IfcSimplePropertyTemplateTypeEnum
    {
        PSinglevalue,
        PEnumeratedvalue,
        PBoundedvalue,
        PListvalue,
        PTablevalue,
        PReferencevalue,
        QLength,
        QArea,
        QVolume,
        QCount,
        QWeight,
        QTime
    }
}