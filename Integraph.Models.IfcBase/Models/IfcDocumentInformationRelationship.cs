using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdocumentinformationrelationship.htm" />
	/// </summary>
	public class IfcDocumentInformationRelationship : IfcResourceLevelRelationship
    {
	    /// <summary>
	    ///     Construct a IfcDocumentInformationRelationship with all required attributes.
	    /// </summary>
	    public IfcDocumentInformationRelationship(IfcDocumentInformation relatingDocument,
            List<IfcDocumentInformation> relatedDocuments)
        {
            RelatingDocument = relatingDocument;
            RelatedDocuments = relatedDocuments;
        }

	    /// <summary>
	    ///     Construct a IfcDocumentInformationRelationship with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDocumentInformationRelationship(IfcLabel name, IfcText description,
            IfcDocumentInformation relatingDocument, List<IfcDocumentInformation> relatedDocuments,
            IfcLabel relationshipType) : base(name, description)
        {
            RelatingDocument = relatingDocument;
            RelatedDocuments = relatedDocuments;
            RelationshipType = relationshipType;
        }

        public IfcDocumentInformation RelatingDocument { get; set; }
        public List<IfcDocumentInformation> RelatedDocuments { get; set; }
        public IfcLabel RelationshipType { get; set; } // optional

        public new static IfcDocumentInformationRelationship FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDocumentInformationRelationship>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingDocument != null ? RelatingDocument.ToStepValue() : "$",
                RelatedDocuments != null ? RelatedDocuments.ToStepValue() : "$",
                RelationshipType != null ? RelationshipType.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}