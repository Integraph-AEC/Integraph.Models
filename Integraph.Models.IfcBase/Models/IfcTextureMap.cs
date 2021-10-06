using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctexturemap.htm" />
	/// </summary>
	public class IfcTextureMap : IfcTextureCoordinate
    {
	    /// <summary>
	    ///     Construct a IfcTextureMap with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTextureMap(List<IfcSurfaceTexture> maps, List<IfcTextureVertex> vertices, IfcFace mappedTo) :
            base(maps)
        {
            Vertices = vertices;
            MappedTo = mappedTo;
        }

        public List<IfcTextureVertex> Vertices { get; set; }
        public IfcFace MappedTo { get; set; }

        public new static IfcTextureMap FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextureMap>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Maps != null ? Maps.ToStepValue() : "$",
                Vertices != null ? Vertices.ToStepValue() : "$",
                MappedTo != null ? MappedTo.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}