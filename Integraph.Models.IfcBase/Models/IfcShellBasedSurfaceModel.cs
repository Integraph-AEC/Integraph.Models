using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcshellbasedsurfacemodel.htm" />
	/// </summary>
	public class IfcShellBasedSurfaceModel : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcShellBasedSurfaceModel with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcShellBasedSurfaceModel(List<IfcShell> sbsmBoundary)
        {
            SbsmBoundary = sbsmBoundary;
        }

        public List<IfcShell> SbsmBoundary { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcShellBasedSurfaceModel FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcShellBasedSurfaceModel>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {SbsmBoundary != null ? SbsmBoundary.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}