using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcprojectedcrs.htm" />
	/// </summary>
	public class IfcProjectedCrs : IfcCoordinateReferenceSystem
    {
	    /// <summary>
	    ///     Construct a IfcProjectedCRS with all required attributes.
	    /// </summary>
	    public IfcProjectedCrs(IfcLabel name) : base(name)
        {
        }

	    /// <summary>
	    ///     Construct a IfcProjectedCRS with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcProjectedCrs(IfcLabel name, IfcText description, IfcIdentifier geodeticDatum,
            IfcIdentifier verticalDatum, IfcIdentifier mapProjection, IfcIdentifier mapZone, IfcNamedUnit mapUnit) :
            base(name, description, geodeticDatum, verticalDatum)
        {
            MapProjection = mapProjection;
            MapZone = mapZone;
            MapUnit = mapUnit;
        }

        public IfcIdentifier MapProjection { get; set; } // optional
        public IfcIdentifier MapZone { get; set; } // optional
        public IfcNamedUnit MapUnit { get; set; } // optional

        public new static IfcProjectedCrs FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcProjectedCrs>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            GeodeticDatum != null ? GeodeticDatum.ToStepValue() : "$",
	            VerticalDatum != null ? VerticalDatum.ToStepValue() : "$",
	            MapProjection != null ? MapProjection.ToStepValue() : "$",
	            MapZone != null ? MapZone.ToStepValue() : "$",
	            MapUnit != null ? MapUnit.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}