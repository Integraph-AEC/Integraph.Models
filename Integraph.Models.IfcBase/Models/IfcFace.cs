using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcface.htm" />
	/// </summary>
	public class IfcFace : IfcTopologicalRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcFace with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFace(List<IfcFaceBound> bounds)
        {
            HasTextureMaps = new List<IfcTextureMap>();

            Bounds = bounds;
        }

        public List<IfcFaceBound> Bounds { get; set; }
        public List<IfcTextureMap> HasTextureMaps { get; set; } // inverse

        public new static IfcFace FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFace>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Bounds != null ? Bounds.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}