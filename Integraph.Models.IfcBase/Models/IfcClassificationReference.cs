using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcclassificationreference.htm" />
	/// </summary>
	public class IfcClassificationReference : IfcExternalReference
    {
	    /// <summary>
	    ///     Construct a IfcClassificationReference with all required attributes.
	    /// </summary>
	    public IfcClassificationReference()
        {
            ClassificationRefForObjects = new List<IfcRelAssociatesClassification>();
            HasReferences = new List<IfcClassificationReference>();
        }

	    /// <summary>
	    ///     Construct a IfcClassificationReference with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcClassificationReference(IfcUriReference location, IfcIdentifier identification, IfcLabel name,
            IfcClassificationReferenceSelect referencedSource, IfcText description, IfcIdentifier sort) : base(location,
            identification, name)
        {
            ClassificationRefForObjects = new List<IfcRelAssociatesClassification>();
            HasReferences = new List<IfcClassificationReference>();

            ReferencedSource = referencedSource;
            Description = description;
            Sort = sort;
        }

        public IfcClassificationReferenceSelect ReferencedSource { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public IfcIdentifier Sort { get; set; } // optional
        public List<IfcRelAssociatesClassification> ClassificationRefForObjects { get; set; } // inverse
        public List<IfcClassificationReference> HasReferences { get; set; } // inverse

        public new static IfcClassificationReference FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcClassificationReference>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Location != null ? Location.ToStepValue() : "$",
	            Identification != null ? Identification.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            ReferencedSource != null ? ReferencedSource.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Sort != null ? Sort.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}