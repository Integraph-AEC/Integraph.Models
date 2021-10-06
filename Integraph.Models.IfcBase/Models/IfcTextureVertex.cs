using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctexturevertex.htm" />
	/// </summary>
	public class IfcTextureVertex : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcTextureVertex with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTextureVertex(List<IfcParameterValue> coordinates)
        {
            Coordinates = coordinates;
        }

        public List<IfcParameterValue> Coordinates { get; set; }

        public new static IfcTextureVertex FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextureVertex>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Coordinates != null ? Coordinates.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}