using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconversionbasedunitwithoffset.htm" />
	/// </summary>
	public class IfcConversionBasedUnitWithOffset : IfcConversionBasedUnit
    {
	    /// <summary>
	    ///     Construct a IfcConversionBasedUnitWithOffset with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConversionBasedUnitWithOffset(IfcDimensionalExponents dimensions, IfcUnitEnum unitType, IfcLabel name,
            IfcMeasureWithUnit conversionFactor, IfcReal conversionOffset) : base(dimensions, unitType, name,
            conversionFactor)
        {
            ConversionOffset = conversionOffset;
        }

        public IfcReal ConversionOffset { get; set; }

        public new static IfcConversionBasedUnitWithOffset FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConversionBasedUnitWithOffset>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Dimensions != null ? Dimensions.ToStepValue() : "$",
                UnitType.ToStepValue(),
                Name != null ? Name.ToStepValue() : "$",
                ConversionFactor != null ? ConversionFactor.ToStepValue() : "$",
                ConversionOffset != null ? ConversionOffset.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}