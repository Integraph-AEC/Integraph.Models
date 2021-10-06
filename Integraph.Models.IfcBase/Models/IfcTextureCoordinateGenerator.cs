using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctexturecoordinategenerator.htm" />
	/// </summary>
	public class IfcTextureCoordinateGenerator : IfcTextureCoordinate
    {
	    /// <summary>
	    ///     Construct a IfcTextureCoordinateGenerator with all required attributes.
	    /// </summary>
	    public IfcTextureCoordinateGenerator(List<IfcSurfaceTexture> maps, IfcLabel mode) : base(maps)
        {
            Parameter = new List<IfcReal>();

            Mode = mode;
        }

	    /// <summary>
	    ///     Construct a IfcTextureCoordinateGenerator with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTextureCoordinateGenerator(List<IfcSurfaceTexture> maps, IfcLabel mode, List<IfcReal> parameter) :
            base(maps)
        {
            Mode = mode;
            Parameter = parameter;
        }

        public IfcLabel Mode { get; set; }
        public List<IfcReal> Parameter { get; set; } // optional

        public new static IfcTextureCoordinateGenerator FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextureCoordinateGenerator>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Maps != null ? Maps.ToStepValue() : "$",
	            Mode != null ? Mode.ToStepValue() : "$",
	            Parameter != null ? Parameter.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}