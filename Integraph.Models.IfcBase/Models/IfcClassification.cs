using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcclassification.htm" />
	/// </summary>
	public class IfcClassification : IfcExternalInformation
    {
	    /// <summary>
	    ///     Construct a IfcClassification with all required attributes.
	    /// </summary>
	    public IfcClassification(IfcLabel name)
        {
            ReferenceTokens = new List<IfcIdentifier>();
            ClassificationForObjects = new List<IfcRelAssociatesClassification>();
            HasReferences = new List<IfcClassificationReference>();

            Name = name;
        }

	    /// <summary>
	    ///     Construct a IfcClassification with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcClassification(IfcLabel source, IfcLabel edition, IfcDate editionDate, IfcLabel name,
            IfcText description, IfcUriReference location, List<IfcIdentifier> referenceTokens)
        {
            ClassificationForObjects = new List<IfcRelAssociatesClassification>();
            HasReferences = new List<IfcClassificationReference>();

            Source = source;
            Edition = edition;
            EditionDate = editionDate;
            Name = name;
            Description = description;
            Location = location;
            ReferenceTokens = referenceTokens;
        }

        public IfcLabel Source { get; set; } // optional
        public IfcLabel Edition { get; set; } // optional
        public IfcDate EditionDate { get; set; } // optional
        public IfcLabel Name { get; set; }
        public IfcText Description { get; set; } // optional
        public IfcUriReference Location { get; set; } // optional
        public List<IfcIdentifier> ReferenceTokens { get; set; } // optional
        public List<IfcRelAssociatesClassification> ClassificationForObjects { get; set; } // inverse
        public List<IfcClassificationReference> HasReferences { get; set; } // inverse

        public new static IfcClassification FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcClassification>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Source != null ? Source.ToStepValue() : "$",
	            Edition != null ? Edition.ToStepValue() : "$",
	            EditionDate != null ? EditionDate.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Location != null ? Location.ToStepValue() : "$",
	            ReferenceTokens != null ? ReferenceTokens.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}