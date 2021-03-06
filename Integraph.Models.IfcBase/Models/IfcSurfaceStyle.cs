using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfacestyle.htm" />
	/// </summary>
	public class IfcSurfaceStyle : IfcPresentationStyle
    {
	    /// <summary>
	    ///     Construct a IfcSurfaceStyle with all required attributes.
	    /// </summary>
	    public IfcSurfaceStyle(IfcSurfaceSide side, List<IfcSurfaceStyleElementSelect> styles)
        {
            Side = side;
            Styles = styles;
        }

	    /// <summary>
	    ///     Construct a IfcSurfaceStyle with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurfaceStyle(IfcLabel name, IfcSurfaceSide side, List<IfcSurfaceStyleElementSelect> styles) :
            base(name)
        {
            Side = side;
            Styles = styles;
        }

        public IfcSurfaceSide? Side { get; set; }
        public List<IfcSurfaceStyleElementSelect> Styles { get; set; }

        public new static IfcSurfaceStyle FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurfaceStyle>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Side != null ? Side.ToStepValue() : "$",
	            Styles != null ? Styles.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}