using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassociatesclassification.htm" />
	/// </summary>
	public class IfcRelAssociatesClassification : IfcRelAssociates
    {
	    /// <summary>
	    ///     Construct a IfcRelAssociatesClassification with all required attributes.
	    /// </summary>
	    public IfcRelAssociatesClassification(IfcGloballyUniqueId globalId, List<IfcDefinitionSelect> relatedObjects,
            IfcClassificationSelect relatingClassification) : base(globalId, relatedObjects)
        {
            RelatingClassification = relatingClassification;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssociatesClassification with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssociatesClassification(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcDefinitionSelect> relatedObjects,
            IfcClassificationSelect relatingClassification) : base(globalId, ownerHistory, name, description,
            relatedObjects)
        {
            RelatingClassification = relatingClassification;
        }

        public IfcClassificationSelect RelatingClassification { get; set; }

        public new static IfcRelAssociatesClassification FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssociatesClassification>(json);
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
                RelatingClassification != null ? RelatingClassification.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}