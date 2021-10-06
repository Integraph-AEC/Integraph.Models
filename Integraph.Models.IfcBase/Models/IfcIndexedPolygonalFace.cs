using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcindexedpolygonalface.htm" />
	/// </summary>
	public class IfcIndexedPolygonalFace : IfcTessellatedItem
    {
	    /// <summary>
	    ///     Construct a IfcIndexedPolygonalFace with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcIndexedPolygonalFace(List<IfcPositiveInteger> coordIndex)
        {
            ToFaceSet = new List<IfcPolygonalFaceSet>();

            CoordIndex = coordIndex;
        }

        public List<IfcPositiveInteger> CoordIndex { get; set; }
        public List<IfcPolygonalFaceSet> ToFaceSet { get; set; } // inverse

        public new static IfcIndexedPolygonalFace FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIndexedPolygonalFace>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {CoordIndex != null ? CoordIndex.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}