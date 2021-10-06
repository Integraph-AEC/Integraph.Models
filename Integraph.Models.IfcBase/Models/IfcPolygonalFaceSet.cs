using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpolygonalfaceset.htm" />
	/// </summary>
	public class IfcPolygonalFaceSet : IfcTessellatedFaceSet
    {
	    /// <summary>
	    ///     Construct a IfcPolygonalFaceSet with all required attributes.
	    /// </summary>
	    public IfcPolygonalFaceSet(IfcCartesianPointList3D coordinates, List<IfcIndexedPolygonalFace> faces) : base(
            coordinates)
        {
            PnIndex = new List<IfcPositiveInteger>();

            Faces = faces;
        }

	    /// <summary>
	    ///     Construct a IfcPolygonalFaceSet with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPolygonalFaceSet(IfcCartesianPointList3D coordinates, IfcBoolean closed,
            List<IfcIndexedPolygonalFace> faces, List<IfcPositiveInteger> pnIndex) : base(coordinates)
        {
            Closed = closed;
            Faces = faces;
            PnIndex = pnIndex;
        }

        public IfcBoolean Closed { get; set; } // optional
        public List<IfcIndexedPolygonalFace> Faces { get; set; }
        public List<IfcPositiveInteger> PnIndex { get; set; } // optional

        public new static IfcPolygonalFaceSet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPolygonalFaceSet>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Coordinates != null ? Coordinates.ToStepValue() : "$",
                Closed != null ? Closed.ToStepValue() : "$",
                Faces != null ? Faces.ToStepValue() : "$",
                PnIndex != null ? PnIndex.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}