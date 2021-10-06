using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcindexedtriangletexturemap.htm" />
	/// </summary>
	public class IfcIndexedTriangleTextureMap : IfcIndexedTextureMap
    {
	    /// <summary>
	    ///     Construct a IfcIndexedTriangleTextureMap with all required attributes.
	    /// </summary>
	    public IfcIndexedTriangleTextureMap(List<IfcSurfaceTexture> maps, IfcTessellatedFaceSet mappedTo,
            IfcTextureVertexList texCoords) : base(maps, mappedTo, texCoords)
        {
            TexCoordIndex = new List<List<IfcPositiveInteger>>();
        }

	    /// <summary>
	    ///     Construct a IfcIndexedTriangleTextureMap with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcIndexedTriangleTextureMap(List<IfcSurfaceTexture> maps, IfcTessellatedFaceSet mappedTo,
            IfcTextureVertexList texCoords, List<List<IfcPositiveInteger>> texCoordIndex) : base(maps, mappedTo,
            texCoords)
        {
            TexCoordIndex = texCoordIndex;
        }

        public List<List<IfcPositiveInteger>> TexCoordIndex { get; set; } // optional

        public new static IfcIndexedTriangleTextureMap FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIndexedTriangleTextureMap>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Maps != null ? Maps.ToStepValue() : "$",
                MappedTo != null ? MappedTo.ToStepValue() : "$",
                TexCoords != null ? TexCoords.ToStepValue() : "$",
                TexCoordIndex != null ? TexCoordIndex.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}