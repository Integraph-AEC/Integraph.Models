using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfacetexture.htm" />
	/// </summary>
	public abstract class IfcSurfaceTexture : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcSurfaceTexture with all required attributes.
	    /// </summary>
	    public IfcSurfaceTexture(IfcBoolean repeatS, IfcBoolean repeatT)
        {
            Parameter = new List<IfcIdentifier>();
            IsMappedBy = new List<IfcTextureCoordinate>();
            UsedInStyles = new List<IfcSurfaceStyleWithTextures>();

            RepeatS = repeatS;
            RepeatT = repeatT;
        }

	    /// <summary>
	    ///     Construct a IfcSurfaceTexture with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurfaceTexture(IfcBoolean repeatS, IfcBoolean repeatT, IfcIdentifier mode,
            IfcCartesianTransformationOperator2D textureTransform, List<IfcIdentifier> parameter)
        {
            IsMappedBy = new List<IfcTextureCoordinate>();
            UsedInStyles = new List<IfcSurfaceStyleWithTextures>();

            RepeatS = repeatS;
            RepeatT = repeatT;
            Mode = mode;
            TextureTransform = textureTransform;
            Parameter = parameter;
        }

        public IfcBoolean RepeatS { get; set; }
        public IfcBoolean RepeatT { get; set; }
        public IfcIdentifier Mode { get; set; } // optional
        public IfcCartesianTransformationOperator2D TextureTransform { get; set; } // optional
        public List<IfcIdentifier> Parameter { get; set; } // optional
        public List<IfcTextureCoordinate> IsMappedBy { get; set; } // inverse
        public List<IfcSurfaceStyleWithTextures> UsedInStyles { get; set; } // inverse

        public new static IfcSurfaceTexture FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurfaceTexture>(json);
        }
    }
}