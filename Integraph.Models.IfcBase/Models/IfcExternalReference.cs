using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcexternalreference.htm" />
	/// </summary>
	public abstract class IfcExternalReference : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcExternalReference with all required attributes.
	    /// </summary>
	    public IfcExternalReference()
        {
            ExternalReferenceForResources = new List<IfcExternalReferenceRelationship>();
        }

	    /// <summary>
	    ///     Construct a IfcExternalReference with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcExternalReference(IfcUriReference location, IfcIdentifier identification, IfcLabel name)
        {
            ExternalReferenceForResources = new List<IfcExternalReferenceRelationship>();

            Location = location;
            Identification = identification;
            Name = name;
        }

        public IfcUriReference Location { get; set; } // optional
        public IfcIdentifier Identification { get; set; } // optional
        public IfcLabel Name { get; set; } // optional
        public List<IfcExternalReferenceRelationship> ExternalReferenceForResources { get; set; } // inverse

        public static IfcExternalReference FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcExternalReference>(json);
        }
    }
}