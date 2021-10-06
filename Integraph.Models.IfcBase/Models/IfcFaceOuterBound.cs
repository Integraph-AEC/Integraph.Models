using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfaceouterbound.htm" />
	/// </summary>
	public class IfcFaceOuterBound : IfcFaceBound
    {
	    /// <summary>
	    ///     Construct a IfcFaceOuterBound with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFaceOuterBound(IfcLoop bound, IfcBoolean orientation) : base(bound, orientation)
        {
        }

        public new static IfcFaceOuterBound FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFaceOuterBound>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Bound != null ? Bound.ToStepValue() : "$",
	            Orientation != null ? Orientation.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}