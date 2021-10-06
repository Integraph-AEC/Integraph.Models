using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcgeometricset.htm" />
	/// </summary>
	public class IfcGeometricSet : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcGeometricSet with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcGeometricSet(List<IfcGeometricSetSelect> elements)
        {
            Elements = elements;
        }

        public List<IfcGeometricSetSelect> Elements { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcGeometricSet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcGeometricSet>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Elements != null ? Elements.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}