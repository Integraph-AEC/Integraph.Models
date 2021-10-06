using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccartesianpoint.htm" />
	/// </summary>
	public class IfcCartesianPoint : IfcPoint
    {
	    /// <summary>
	    ///     Construct a IfcCartesianPoint with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCartesianPoint(List<IfcLengthMeasure> coordinates)
        {
            Coordinates = coordinates;
        }

        public List<IfcLengthMeasure> Coordinates { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcCartesianPoint FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCartesianPoint>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Coordinates != null ? Coordinates.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}