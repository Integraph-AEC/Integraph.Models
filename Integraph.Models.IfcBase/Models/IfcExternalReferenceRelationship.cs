using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcexternalreferencerelationship.htm" />
	/// </summary>
	public class IfcExternalReferenceRelationship : IfcResourceLevelRelationship
    {
	    /// <summary>
	    ///     Construct a IfcExternalReferenceRelationship with all required attributes.
	    /// </summary>
	    public IfcExternalReferenceRelationship(IfcExternalReference relatingReference,
            List<IfcResourceObjectSelect> relatedResourceObjects)
        {
            RelatingReference = relatingReference;
            RelatedResourceObjects = relatedResourceObjects;
        }

	    /// <summary>
	    ///     Construct a IfcExternalReferenceRelationship with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcExternalReferenceRelationship(IfcLabel name, IfcText description,
            IfcExternalReference relatingReference, List<IfcResourceObjectSelect> relatedResourceObjects) : base(name,
            description)
        {
            RelatingReference = relatingReference;
            RelatedResourceObjects = relatedResourceObjects;
        }

        public IfcExternalReference RelatingReference { get; set; }
        public List<IfcResourceObjectSelect> RelatedResourceObjects { get; set; }

        public new static IfcExternalReferenceRelationship FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcExternalReferenceRelationship>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingReference != null ? RelatingReference.ToStepValue() : "$",
                RelatedResourceObjects != null ? RelatedResourceObjects.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}