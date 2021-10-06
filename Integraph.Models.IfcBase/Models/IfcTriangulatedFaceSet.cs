using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctriangulatedfaceset.htm" />
	/// </summary>
	public class IfcTriangulatedFaceSet : IfcTessellatedFaceSet
    {
	    /// <summary>
	    ///     Construct a IfcTriangulatedFaceSet with all required attributes.
	    /// </summary>
	    public IfcTriangulatedFaceSet(IfcCartesianPointList3D coordinates, List<List<IfcPositiveInteger>> coordIndex) :
            base(coordinates)
        {
            Normals = new List<List<IfcParameterValue>>();
            PnIndex = new List<IfcPositiveInteger>();

            CoordIndex = coordIndex;
        }

	    /// <summary>
	    ///     Construct a IfcTriangulatedFaceSet with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTriangulatedFaceSet(IfcCartesianPointList3D coordinates, List<List<IfcParameterValue>> normals,
            IfcBoolean closed, List<List<IfcPositiveInteger>> coordIndex, List<IfcPositiveInteger> pnIndex) : base(
            coordinates)
        {
            Normals = normals;
            Closed = closed;
            CoordIndex = coordIndex;
            PnIndex = pnIndex;
        }

        public List<List<IfcParameterValue>> Normals { get; set; } // optional
        public IfcBoolean Closed { get; set; } // optional
        public List<List<IfcPositiveInteger>> CoordIndex { get; set; }
        public List<IfcPositiveInteger> PnIndex { get; set; } // optional

        [JsonIgnore]
        public IfcInteger NumberOfTriangles =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for NumberOfTriangles."); // derived

        public new static IfcTriangulatedFaceSet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTriangulatedFaceSet>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Coordinates != null ? Coordinates.ToStepValue() : "$",
                Normals != null ? Normals.ToStepValue() : "$",
                Closed != null ? Closed.ToStepValue() : "$",
                CoordIndex != null ? CoordIndex.ToStepValue() : "$",
                PnIndex != null ? PnIndex.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}