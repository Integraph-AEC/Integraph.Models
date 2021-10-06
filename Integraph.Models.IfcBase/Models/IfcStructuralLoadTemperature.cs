using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralloadtemperature.htm" />
	/// </summary>
	public class IfcStructuralLoadTemperature : IfcStructuralLoadStatic
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLoadTemperature with all required attributes.
	    /// </summary>
	    public IfcStructuralLoadTemperature()
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLoadTemperature with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLoadTemperature(IfcLabel name, IfcThermodynamicTemperatureMeasure deltaTConstant,
            IfcThermodynamicTemperatureMeasure deltaTy, IfcThermodynamicTemperatureMeasure deltaTz) : base(name)
        {
            DeltaTConstant = deltaTConstant;
            DeltaTy = deltaTy;
            DeltaTz = deltaTz;
        }

        public IfcThermodynamicTemperatureMeasure DeltaTConstant { get; set; } // optional
        public IfcThermodynamicTemperatureMeasure DeltaTy { get; set; } // optional
        public IfcThermodynamicTemperatureMeasure DeltaTz { get; set; } // optional

        public new static IfcStructuralLoadTemperature FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLoadTemperature>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            DeltaTConstant != null ? DeltaTConstant.ToStepValue() : "$",
	            DeltaTy != null ? DeltaTy.ToStepValue() : "$",
	            DeltaTz != null ? DeltaTz.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}