using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctexturecoordinate.htm" />
	/// </summary>
	public abstract class IfcTextureCoordinate : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcTextureCoordinate with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTextureCoordinate(List<IfcSurfaceTexture> maps)
        {
            Maps = maps;
        }

        public List<IfcSurfaceTexture> Maps { get; set; }

        public new static IfcTextureCoordinate FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextureCoordinate>(json);
        }
    }
}