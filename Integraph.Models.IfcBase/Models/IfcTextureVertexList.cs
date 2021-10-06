using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctexturevertexlist.htm" />
	/// </summary>
	public class IfcTextureVertexList : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcTextureVertexList with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTextureVertexList(List<List<IfcParameterValue>> texCoordsList)
        {
            TexCoordsList = texCoordsList;
        }

        public List<List<IfcParameterValue>> TexCoordsList { get; set; }

        public new static IfcTextureVertexList FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextureVertexList>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {TexCoordsList != null ? TexCoordsList.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}