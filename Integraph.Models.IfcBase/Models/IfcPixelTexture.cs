using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpixeltexture.htm" />
	/// </summary>
	public class IfcPixelTexture : IfcSurfaceTexture
    {
	    /// <summary>
	    ///     Construct a IfcPixelTexture with all required attributes.
	    /// </summary>
	    public IfcPixelTexture(IfcBoolean repeatS, IfcBoolean repeatT, IfcInteger width, IfcInteger height,
            IfcInteger colourComponents, List<IfcBinary> pixel) : base(repeatS, repeatT)
        {
            Width = width;
            Height = height;
            ColourComponents = colourComponents;
            Pixel = pixel;
        }

	    /// <summary>
	    ///     Construct a IfcPixelTexture with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPixelTexture(IfcBoolean repeatS, IfcBoolean repeatT, IfcIdentifier mode,
            IfcCartesianTransformationOperator2D textureTransform, List<IfcIdentifier> parameter, IfcInteger width,
            IfcInteger height, IfcInteger colourComponents, List<IfcBinary> pixel) : base(repeatS, repeatT, mode,
            textureTransform, parameter)
        {
            Width = width;
            Height = height;
            ColourComponents = colourComponents;
            Pixel = pixel;
        }

        public IfcInteger Width { get; set; }
        public IfcInteger Height { get; set; }
        public IfcInteger ColourComponents { get; set; }
        public List<IfcBinary> Pixel { get; set; }

        public new static IfcPixelTexture FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPixelTexture>(json);
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
                Width != null ? Width.ToStepValue() : "$",
                Height != null ? Height.ToStepValue() : "$",
                ColourComponents != null ? ColourComponents.ToStepValue() : "$",
                Pixel != null ? Pixel.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}