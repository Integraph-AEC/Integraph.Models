using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcaxis2placement3d.htm" />
	/// </summary>
	public class IfcAxis2Placement3D : IfcPlacement
    {
	    /// <summary>
	    ///     Construct a IfcAxis2Placement3D with all required attributes.
	    /// </summary>
	    public IfcAxis2Placement3D(IfcCartesianPoint location) : base(location)
        {
        }

	    /// <summary>
	    ///     Construct a IfcAxis2Placement3D with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcAxis2Placement3D(IfcCartesianPoint location, IfcDirection axis, IfcDirection refDirection) :
            base(location)
        {
            Axis = axis;
            RefDirection = refDirection;
        }

        public IfcDirection Axis { get; set; } // optional
        public IfcDirection RefDirection { get; set; } // optional

        [JsonIgnore]
        public List<IfcDirection> P =>
            throw new NotImplementedException("Derived property logic has been implemented for P."); // derived

        public new static IfcAxis2Placement3D FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAxis2Placement3D>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Location != null ? Location.ToStepValue() : "$",
	            Axis != null ? Axis.ToStepValue() : "$",
	            RefDirection != null ? RefDirection.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}