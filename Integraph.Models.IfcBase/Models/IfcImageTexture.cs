using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcimagetexture.htm" />
	/// </summary>
	public class IfcImageTexture : IfcSurfaceTexture
    {
	    /// <summary>
	    ///     Construct a IfcImageTexture with all required attributes.
	    /// </summary>
	    public IfcImageTexture(IfcBoolean repeatS, IfcBoolean repeatT, IfcUriReference uRlReference) : base(repeatS,
            repeatT)
        {
            UrlReference = uRlReference;
        }

	    /// <summary>
	    ///     Construct a IfcImageTexture with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcImageTexture(IfcBoolean repeatS, IfcBoolean repeatT, IfcIdentifier mode,
            IfcCartesianTransformationOperator2D textureTransform, List<IfcIdentifier> parameter,
            IfcUriReference uRlReference) : base(repeatS, repeatT, mode, textureTransform, parameter)
        {
            UrlReference = uRlReference;
        }

        public IfcUriReference UrlReference { get; set; }

        public new static IfcImageTexture FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcImageTexture>(json);
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
                UrlReference != null ? UrlReference.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}