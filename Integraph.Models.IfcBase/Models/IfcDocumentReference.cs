using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdocumentreference.htm" />
	/// </summary>
	public class IfcDocumentReference : IfcExternalReference
    {
	    /// <summary>
	    ///     Construct a IfcDocumentReference with all required attributes.
	    /// </summary>
	    public IfcDocumentReference()
        {
            DocumentRefForObjects = new List<IfcRelAssociatesDocument>();
        }

	    /// <summary>
	    ///     Construct a IfcDocumentReference with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDocumentReference(IfcUriReference location, IfcIdentifier identification, IfcLabel name,
            IfcText description, IfcDocumentInformation referencedDocument) : base(location, identification, name)
        {
            DocumentRefForObjects = new List<IfcRelAssociatesDocument>();

            Description = description;
            ReferencedDocument = referencedDocument;
        }

        public IfcText Description { get; set; } // optional
        public IfcDocumentInformation ReferencedDocument { get; set; } // optional
        public List<IfcRelAssociatesDocument> DocumentRefForObjects { get; set; } // inverse

        public new static IfcDocumentReference FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDocumentReference>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Location != null ? Location.ToStepValue() : "$",
	            Identification != null ? Identification.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ReferencedDocument != null ? ReferencedDocument.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}