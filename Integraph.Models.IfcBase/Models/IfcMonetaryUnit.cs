using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmonetaryunit.htm" />
	/// </summary>
	public class IfcMonetaryUnit : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcMonetaryUnit with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMonetaryUnit(IfcLabel currency)
        {
            Currency = currency;
        }

        public IfcLabel Currency { get; set; }

        public static IfcMonetaryUnit FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMonetaryUnit>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Currency != null ? Currency.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}