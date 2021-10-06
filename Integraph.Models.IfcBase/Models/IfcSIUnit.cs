using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsiunit.htm" />
	/// </summary>
	public class IfcSiUnit : IfcNamedUnit
    {
	    /// <summary>
	    ///     Construct a IfcSIUnit with all required attributes.
	    /// </summary>
	    public IfcSiUnit(IfcDimensionalExponents dimensions, IfcUnitEnum unitType, IfcSiUnitName name) : base(
            dimensions, unitType)
        {
            Name = name;
        }

	    /// <summary>
	    ///     Construct a IfcSIUnit with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSiUnit(IfcDimensionalExponents dimensions, IfcUnitEnum unitType, IfcSiPrefix prefix,
            IfcSiUnitName name) : base(dimensions, unitType)
        {
            Prefix = prefix;
            Name = name;
        }

        public IfcSiPrefix? Prefix { get; set; } // optional
        public IfcSiUnitName? Name { get; set; }

        [JsonIgnore]
        public new IfcDimensionalExponents Dimensions =>
            throw new NotImplementedException("Derived property logic has been implemented for Dimensions."); // derived

        public new static IfcSiUnit FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSiUnit>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                "*",
                UnitType.ToStepValue(),
                Prefix != null ? Prefix.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}