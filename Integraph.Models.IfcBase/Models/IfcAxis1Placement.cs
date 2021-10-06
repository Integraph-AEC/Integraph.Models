using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcaxis1placement.htm" />
	/// </summary>
	public class IfcAxis1Placement : IfcPlacement
    {
	    /// <summary>
	    ///     Construct a IfcAxis1Placement with all required attributes.
	    /// </summary>
	    public IfcAxis1Placement(IfcCartesianPoint location) : base(location)
        {
        }

	    /// <summary>
	    ///     Construct a IfcAxis1Placement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcAxis1Placement(IfcCartesianPoint location, IfcDirection axis) : base(location)
        {
            Axis = axis;
        }

        public IfcDirection Axis { get; set; } // optional

        [JsonIgnore]
        public IfcDirection Z =>
            throw new NotImplementedException("Derived property logic has been implemented for Z."); // derived

        public new static IfcAxis1Placement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAxis1Placement>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Location != null ? Location.ToStepValue() : "$",
	            Axis != null ? Axis.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}