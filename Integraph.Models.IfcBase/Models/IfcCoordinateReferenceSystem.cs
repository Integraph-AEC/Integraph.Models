using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccoordinatereferencesystem.htm" />
	/// </summary>
	public abstract class IfcCoordinateReferenceSystem : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcCoordinateReferenceSystem with all required attributes.
	    /// </summary>
	    public IfcCoordinateReferenceSystem(IfcLabel name)
        {
            HasCoordinateOperation = new List<IfcCoordinateOperation>();

            Name = name;
        }

	    /// <summary>
	    ///     Construct a IfcCoordinateReferenceSystem with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCoordinateReferenceSystem(IfcLabel name, IfcText description, IfcIdentifier geodeticDatum,
            IfcIdentifier verticalDatum)
        {
            HasCoordinateOperation = new List<IfcCoordinateOperation>();

            Name = name;
            Description = description;
            GeodeticDatum = geodeticDatum;
            VerticalDatum = verticalDatum;
        }

        public IfcLabel Name { get; set; }
        public IfcText Description { get; set; } // optional
        public IfcIdentifier GeodeticDatum { get; set; } // optional
        public IfcIdentifier VerticalDatum { get; set; } // optional
        public List<IfcCoordinateOperation> HasCoordinateOperation { get; set; } // inverse

        public static IfcCoordinateReferenceSystem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCoordinateReferenceSystem>(json);
        }
    }
}