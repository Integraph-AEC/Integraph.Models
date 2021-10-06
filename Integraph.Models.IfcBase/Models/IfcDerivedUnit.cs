using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcderivedunit.htm" />
	/// </summary>
	public class IfcDerivedUnit : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcDerivedUnit with all required attributes.
	    /// </summary>
	    public IfcDerivedUnit(List<IfcDerivedUnitElement> elements, IfcDerivedUnitEnum unitType)
        {
            Elements = elements;
            UnitType = unitType;
        }

	    /// <summary>
	    ///     Construct a IfcDerivedUnit with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDerivedUnit(List<IfcDerivedUnitElement> elements, IfcDerivedUnitEnum unitType,
            IfcLabel userDefinedType)
        {
            Elements = elements;
            UnitType = unitType;
            UserDefinedType = userDefinedType;
        }

        public List<IfcDerivedUnitElement> Elements { get; set; }
        public IfcDerivedUnitEnum? UnitType { get; set; }
        public IfcLabel UserDefinedType { get; set; } // optional

        [JsonIgnore]
        public IfcDimensionalExponents Dimensions =>
            throw new NotImplementedException("Derived property logic has been implemented for Dimensions."); // derived

        public static IfcDerivedUnit FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDerivedUnit>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Elements != null ? Elements.ToStepValue() : "$",
                UnitType.ToStepValue(),
                UserDefinedType != null ? UserDefinedType.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}