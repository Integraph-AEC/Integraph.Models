using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassociatesdocument.htm" />
	/// </summary>
	public class IfcRelAssociatesDocument : IfcRelAssociates
    {
	    /// <summary>
	    ///     Construct a IfcRelAssociatesDocument with all required attributes.
	    /// </summary>
	    public IfcRelAssociatesDocument(IfcGloballyUniqueId globalId, List<IfcDefinitionSelect> relatedObjects,
            IfcDocumentSelect relatingDocument) : base(globalId, relatedObjects)
        {
            RelatingDocument = relatingDocument;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssociatesDocument with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssociatesDocument(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcDefinitionSelect> relatedObjects, IfcDocumentSelect relatingDocument) : base(
            globalId, ownerHistory, name, description, relatedObjects)
        {
            RelatingDocument = relatingDocument;
        }

        public IfcDocumentSelect RelatingDocument { get; set; }

        public new static IfcRelAssociatesDocument FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssociatesDocument>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatedObjects != null ? RelatedObjects.ToStepValue() : "$",
                RelatingDocument != null ? RelatingDocument.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}