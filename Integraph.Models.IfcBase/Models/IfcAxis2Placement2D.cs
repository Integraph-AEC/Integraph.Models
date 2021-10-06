using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcaxis2placement2d.htm" />
	/// </summary>
	public class IfcAxis2Placement2D : IfcPlacement
    {
	    /// <summary>
	    ///     Construct a IfcAxis2Placement2D with all required attributes.
	    /// </summary>
	    public IfcAxis2Placement2D(IfcCartesianPoint location) : base(location)
        {
        }

	    /// <summary>
	    ///     Construct a IfcAxis2Placement2D with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcAxis2Placement2D(IfcCartesianPoint location, IfcDirection refDirection) : base(location)
        {
            RefDirection = refDirection;
        }

        public IfcDirection RefDirection { get; set; } // optional

        [JsonIgnore]
        public List<IfcDirection> P =>
            throw new NotImplementedException("Derived property logic has been implemented for P."); // derived

        public new static IfcAxis2Placement2D FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAxis2Placement2D>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Location != null ? Location.ToStepValue() : "$",
	            RefDirection != null ? RefDirection.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}