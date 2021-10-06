using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralloadconfiguration.htm" />
	/// </summary>
	public class IfcStructuralLoadConfiguration : IfcStructuralLoad
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLoadConfiguration with all required attributes.
	    /// </summary>
	    public IfcStructuralLoadConfiguration(List<IfcStructuralLoadOrResult> values)
        {
            Locations = new List<List<IfcLengthMeasure>>();

            Values = values;
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLoadConfiguration with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLoadConfiguration(IfcLabel name, List<IfcStructuralLoadOrResult> values,
            List<List<IfcLengthMeasure>> locations) : base(name)
        {
            Values = values;
            Locations = locations;
        }

        public List<IfcStructuralLoadOrResult> Values { get; set; }
        public List<List<IfcLengthMeasure>> Locations { get; set; } // optional

        public new static IfcStructuralLoadConfiguration FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLoadConfiguration>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Values != null ? Values.ToStepValue() : "$",
	            Locations != null ? Locations.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}