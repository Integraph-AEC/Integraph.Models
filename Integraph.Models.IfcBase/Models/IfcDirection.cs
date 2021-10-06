using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdirection.htm" />
	/// </summary>
	public class IfcDirection : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcDirection with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDirection(List<IfcReal> directionRatios)
        {
            DirectionRatios = directionRatios;
        }

        public List<IfcReal> DirectionRatios { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcDirection FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDirection>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {DirectionRatios != null ? DirectionRatios.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}