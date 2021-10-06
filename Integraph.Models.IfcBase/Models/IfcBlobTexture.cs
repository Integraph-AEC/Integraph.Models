using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcblobtexture.htm" />
	/// </summary>
	public class IfcBlobTexture : IfcSurfaceTexture
    {
	    /// <summary>
	    ///     Construct a IfcBlobTexture with all required attributes.
	    /// </summary>
	    public IfcBlobTexture(IfcBoolean repeatS, IfcBoolean repeatT, IfcIdentifier rasterFormat, IfcBinary rasterCode)
            : base(repeatS, repeatT)
        {
            RasterFormat = rasterFormat;
            RasterCode = rasterCode;
        }

	    /// <summary>
	    ///     Construct a IfcBlobTexture with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBlobTexture(IfcBoolean repeatS, IfcBoolean repeatT, IfcIdentifier mode,
            IfcCartesianTransformationOperator2D textureTransform, List<IfcIdentifier> parameter,
            IfcIdentifier rasterFormat, IfcBinary rasterCode) : base(repeatS, repeatT, mode, textureTransform,
            parameter)
        {
            RasterFormat = rasterFormat;
            RasterCode = rasterCode;
        }

        public IfcIdentifier RasterFormat { get; set; }
        public IfcBinary RasterCode { get; set; }

        public new static IfcBlobTexture FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBlobTexture>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                RepeatS != null ? RepeatS.ToStepValue() : "$",
                RepeatT != null ? RepeatT.ToStepValue() : "$",
                Mode != null ? Mode.ToStepValue() : "$",
                TextureTransform != null ? TextureTransform.ToStepValue() : "$",
                Parameter != null ? Parameter.ToStepValue() : "$",
                RasterFormat != null ? RasterFormat.ToStepValue() : "$",
                RasterCode != null ? RasterCode.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}