using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfacestylewithtextures.htm" />
	/// </summary>
	public class IfcSurfaceStyleWithTextures : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcSurfaceStyleWithTextures with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurfaceStyleWithTextures(List<IfcSurfaceTexture> textures)
        {
            Textures = textures;
        }

        public List<IfcSurfaceTexture> Textures { get; set; }

        public new static IfcSurfaceStyleWithTextures FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurfaceStyleWithTextures>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Textures != null ? Textures.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}