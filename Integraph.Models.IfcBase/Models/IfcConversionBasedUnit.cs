using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconversionbasedunit.htm" />
	/// </summary>
	public class IfcConversionBasedUnit : IfcNamedUnit
    {
	    /// <summary>
	    ///     Construct a IfcConversionBasedUnit with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConversionBasedUnit(IfcDimensionalExponents dimensions, IfcUnitEnum unitType, IfcLabel name,
            IfcMeasureWithUnit conversionFactor) : base(dimensions, unitType)
        {
            HasExternalReference = new List<IfcExternalReferenceRelationship>();

            Name = name;
            ConversionFactor = conversionFactor;
        }

        public IfcLabel Name { get; set; }
        public IfcMeasureWithUnit ConversionFactor { get; set; }
        public List<IfcExternalReferenceRelationship> HasExternalReference { get; set; } // inverse

        public new static IfcConversionBasedUnit FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConversionBasedUnit>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Dimensions != null ? Dimensions.ToStepValue() : "$",
                UnitType.ToStepValue(),
                Name != null ? Name.ToStepValue() : "$",
                ConversionFactor != null ? ConversionFactor.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}