using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsectionedspine.htm" />
	/// </summary>
	public class IfcSectionedSpine : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcSectionedSpine with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSectionedSpine(IfcCompositeCurve spineCurve, List<IfcProfileDef> crossSections,
            List<IfcAxis2Placement3D> crossSectionPositions)
        {
            SpineCurve = spineCurve;
            CrossSections = crossSections;
            CrossSectionPositions = crossSectionPositions;
        }

        public IfcCompositeCurve SpineCurve { get; set; }
        public List<IfcProfileDef> CrossSections { get; set; }
        public List<IfcAxis2Placement3D> CrossSectionPositions { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcSectionedSpine FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSectionedSpine>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                SpineCurve != null ? SpineCurve.ToStepValue() : "$",
                CrossSections != null ? CrossSections.ToStepValue() : "$",
                CrossSectionPositions != null ? CrossSectionPositions.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}