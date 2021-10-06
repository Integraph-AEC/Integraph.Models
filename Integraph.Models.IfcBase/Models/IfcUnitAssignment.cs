using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcunitassignment.htm" />
	/// </summary>
	public class IfcUnitAssignment : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcUnitAssignment with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcUnitAssignment(List<IfcUnit> units)
        {
            Units = units;
        }

        public List<IfcUnit> Units { get; set; }

        public static IfcUnitAssignment FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcUnitAssignment>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Units != null ? Units.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}