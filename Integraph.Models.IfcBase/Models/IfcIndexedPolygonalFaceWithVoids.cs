using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcindexedpolygonalfacewithvoids.htm" />
	/// </summary>
	public class IfcIndexedPolygonalFaceWithVoids : IfcIndexedPolygonalFace
    {
	    /// <summary>
	    ///     Construct a IfcIndexedPolygonalFaceWithVoids with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcIndexedPolygonalFaceWithVoids(List<IfcPositiveInteger> coordIndex,
            List<List<IfcPositiveInteger>> innerCoordIndices) : base(coordIndex)
        {
            InnerCoordIndices = innerCoordIndices;
        }

        public List<List<IfcPositiveInteger>> InnerCoordIndices { get; set; }

        public new static IfcIndexedPolygonalFaceWithVoids FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIndexedPolygonalFaceWithVoids>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                CoordIndex != null ? CoordIndex.ToStepValue() : "$",
                InnerCoordIndices != null ? InnerCoordIndices.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}