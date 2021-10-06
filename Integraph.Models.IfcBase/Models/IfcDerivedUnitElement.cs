using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcderivedunitelement.htm" />
	/// </summary>
	public class IfcDerivedUnitElement : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcDerivedUnitElement with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDerivedUnitElement(IfcNamedUnit unit, int exponent)
        {
            Unit = unit;
            Exponent = exponent;
        }

        public IfcNamedUnit Unit { get; set; }
        public int Exponent { get; set; }

        public static IfcDerivedUnitElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDerivedUnitElement>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Unit != null ? Unit.ToStepValue() : "$",
	            Exponent.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}