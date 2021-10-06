using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcvector.htm" />
	/// </summary>
	public class IfcVector : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcVector with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcVector(IfcDirection orientation, IfcLengthMeasure magnitude)
        {
            Orientation = orientation;
            Magnitude = magnitude;
        }

        public IfcDirection Orientation { get; set; }
        public IfcLengthMeasure Magnitude { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcVector FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcVector>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Orientation != null ? Orientation.ToStepValue() : "$",
                Magnitude != null ? Magnitude.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}