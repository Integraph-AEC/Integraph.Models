using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcindexedtexturemap.htm" />
	/// </summary>
	public abstract class IfcIndexedTextureMap : IfcTextureCoordinate
    {
	    /// <summary>
	    ///     Construct a IfcIndexedTextureMap with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcIndexedTextureMap(List<IfcSurfaceTexture> maps, IfcTessellatedFaceSet mappedTo,
            IfcTextureVertexList texCoords) : base(maps)
        {
            MappedTo = mappedTo;
            TexCoords = texCoords;
        }

        public IfcTessellatedFaceSet MappedTo { get; set; }
        public IfcTextureVertexList TexCoords { get; set; }

        public new static IfcIndexedTextureMap FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIndexedTextureMap>(json);
        }
    }
}