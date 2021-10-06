using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfacebasedsurfacemodel.htm" />
	/// </summary>
	public class IfcFaceBasedSurfaceModel : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcFaceBasedSurfaceModel with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFaceBasedSurfaceModel(List<IfcConnectedFaceSet> fbsmFaces)
        {
            FbsmFaces = fbsmFaces;
        }

        public List<IfcConnectedFaceSet> FbsmFaces { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcFaceBasedSurfaceModel FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFaceBasedSurfaceModel>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {FbsmFaces != null ? FbsmFaces.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}