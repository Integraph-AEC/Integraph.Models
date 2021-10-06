using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfillareastyletiles.htm" />
	/// </summary>
	public class IfcFillAreaStyleTiles : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcFillAreaStyleTiles with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFillAreaStyleTiles(List<IfcVector> tilingPattern, List<IfcStyledItem> tiles,
            IfcPositiveRatioMeasure tilingScale)
        {
            TilingPattern = tilingPattern;
            Tiles = tiles;
            TilingScale = tilingScale;
        }

        public List<IfcVector> TilingPattern { get; set; }
        public List<IfcStyledItem> Tiles { get; set; }
        public IfcPositiveRatioMeasure TilingScale { get; set; }

        public new static IfcFillAreaStyleTiles FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFillAreaStyleTiles>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                TilingPattern != null ? TilingPattern.ToStepValue() : "$",
                Tiles != null ? Tiles.ToStepValue() : "$",
                TilingScale != null ? TilingScale.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}