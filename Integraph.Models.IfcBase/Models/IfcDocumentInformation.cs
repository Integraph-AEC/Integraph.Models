using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdocumentinformation.htm" />
	/// </summary>
	public class IfcDocumentInformation : IfcExternalInformation
    {
	    /// <summary>
	    ///     Construct a IfcDocumentInformation with all required attributes.
	    /// </summary>
	    public IfcDocumentInformation(IfcIdentifier identification, IfcLabel name)
        {
            Editors = new List<IfcActorSelect>();
            DocumentInfoForObjects = new List<IfcRelAssociatesDocument>();
            HasDocumentReferences = new List<IfcDocumentReference>();
            IsPointedTo = new List<IfcDocumentInformationRelationship>();
            IsPointer = new List<IfcDocumentInformationRelationship>();

            Identification = identification;
            Name = name;
        }

	    /// <summary>
	    ///     Construct a IfcDocumentInformation with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDocumentInformation(IfcIdentifier identification, IfcLabel name, IfcText description,
            IfcUriReference location, IfcText purpose, IfcText intendedUse, IfcText scope, IfcLabel revision,
            IfcActorSelect documentOwner, List<IfcActorSelect> editors, IfcDateTime creationTime,
            IfcDateTime lastRevisionTime, IfcIdentifier electronicFormat, IfcDate validFrom, IfcDate validUntil,
            IfcDocumentConfidentialityEnum confidentiality, IfcDocumentStatusEnum status)
        {
            DocumentInfoForObjects = new List<IfcRelAssociatesDocument>();
            HasDocumentReferences = new List<IfcDocumentReference>();
            IsPointedTo = new List<IfcDocumentInformationRelationship>();
            IsPointer = new List<IfcDocumentInformationRelationship>();

            Identification = identification;
            Name = name;
            Description = description;
            Location = location;
            Purpose = purpose;
            IntendedUse = intendedUse;
            Scope = scope;
            Revision = revision;
            DocumentOwner = documentOwner;
            Editors = editors;
            CreationTime = creationTime;
            LastRevisionTime = lastRevisionTime;
            ElectronicFormat = electronicFormat;
            ValidFrom = validFrom;
            ValidUntil = validUntil;
            Confidentiality = confidentiality;
            Status = status;
        }

        public IfcIdentifier Identification { get; set; }
        public IfcLabel Name { get; set; }
        public IfcText Description { get; set; } // optional
        public IfcUriReference Location { get; set; } // optional
        public IfcText Purpose { get; set; } // optional
        public IfcText IntendedUse { get; set; } // optional
        public IfcText Scope { get; set; } // optional
        public IfcLabel Revision { get; set; } // optional
        public IfcActorSelect DocumentOwner { get; set; } // optional
        public List<IfcActorSelect> Editors { get; set; } // optional
        public IfcDateTime CreationTime { get; set; } // optional
        public IfcDateTime LastRevisionTime { get; set; } // optional
        public IfcIdentifier ElectronicFormat { get; set; } // optional
        public IfcDate ValidFrom { get; set; } // optional
        public IfcDate ValidUntil { get; set; } // optional
        public IfcDocumentConfidentialityEnum? Confidentiality { get; set; } // optional
        public IfcDocumentStatusEnum? Status { get; set; } // optional
        public List<IfcRelAssociatesDocument> DocumentInfoForObjects { get; set; } // inverse
        public List<IfcDocumentReference> HasDocumentReferences { get; set; } // inverse
        public List<IfcDocumentInformationRelationship> IsPointedTo { get; set; } // inverse
        public List<IfcDocumentInformationRelationship> IsPointer { get; set; } // inverse

        public new static IfcDocumentInformation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDocumentInformation>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Identification != null ? Identification.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Location != null ? Location.ToStepValue() : "$",
	            Purpose != null ? Purpose.ToStepValue() : "$",
	            IntendedUse != null ? IntendedUse.ToStepValue() : "$",
	            Scope != null ? Scope.ToStepValue() : "$",
	            Revision != null ? Revision.ToStepValue() : "$",
	            DocumentOwner != null ? DocumentOwner.ToStepValue() : "$",
	            Editors != null ? Editors.ToStepValue() : "$",
	            CreationTime != null ? CreationTime.ToStepValue() : "$",
	            LastRevisionTime != null ? LastRevisionTime.ToStepValue() : "$",
	            ElectronicFormat != null ? ElectronicFormat.ToStepValue() : "$",
	            ValidFrom != null ? ValidFrom.ToStepValue() : "$",
	            ValidUntil != null ? ValidUntil.ToStepValue() : "$",
	            Confidentiality.ToStepValue(),
	            Status.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}