using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcnamedunit.htm" />
	/// </summary>
	public abstract class IfcNamedUnit : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcNamedUnit with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcNamedUnit(IfcDimensionalExponents dimensions, IfcUnitEnum unitType)
        {
            Dimensions = dimensions;
            UnitType = unitType;
        }

        public IfcDimensionalExponents Dimensions { get; set; }
        public IfcUnitEnum? UnitType { get; set; }

        public static IfcNamedUnit FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcNamedUnit>(json);
        }
    }
}