using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcproductrepresentation.htm" />
	/// </summary>
	public abstract class IfcProductRepresentation : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcProductRepresentation with all required attributes.
	    /// </summary>
	    public IfcProductRepresentation(List<IfcRepresentation> representations)
        {
            Representations = representations;
        }

	    /// <summary>
	    ///     Construct a IfcProductRepresentation with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcProductRepresentation(IfcLabel name, IfcText description, List<IfcRepresentation> representations)
        {
            Name = name;
            Description = description;
            Representations = representations;
        }

        public IfcLabel Name { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public List<IfcRepresentation> Representations { get; set; }

        public static IfcProductRepresentation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcProductRepresentation>(json);
        }
    }
}