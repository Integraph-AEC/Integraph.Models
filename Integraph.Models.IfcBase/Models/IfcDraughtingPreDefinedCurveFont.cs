using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdraughtingpredefinedcurvefont.htm" />
	/// </summary>
	public class IfcDraughtingPreDefinedCurveFont : IfcPreDefinedCurveFont
    {
	    /// <summary>
	    ///     Construct a IfcDraughtingPreDefinedCurveFont with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDraughtingPreDefinedCurveFont(IfcLabel name) : base(name)
        {
        }

        public new static IfcDraughtingPreDefinedCurveFont FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDraughtingPreDefinedCurveFont>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Name != null ? Name.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}