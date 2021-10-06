using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdraughtingpredefinedcolour.htm" />
	/// </summary>
	public class IfcDraughtingPreDefinedColour : IfcPreDefinedColour
    {
	    /// <summary>
	    ///     Construct a IfcDraughtingPreDefinedColour with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDraughtingPreDefinedColour(IfcLabel name) : base(name)
        {
        }

        public new static IfcDraughtingPreDefinedColour FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDraughtingPreDefinedColour>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Name != null ? Name.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}