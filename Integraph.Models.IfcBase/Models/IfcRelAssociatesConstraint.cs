using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassociatesconstraint.htm" />
	/// </summary>
	public class IfcRelAssociatesConstraint : IfcRelAssociates
    {
	    /// <summary>
	    ///     Construct a IfcRelAssociatesConstraint with all required attributes.
	    /// </summary>
	    public IfcRelAssociatesConstraint(IfcGloballyUniqueId globalId, List<IfcDefinitionSelect> relatedObjects,
            IfcConstraint relatingConstraint) : base(globalId, relatedObjects)
        {
            RelatingConstraint = relatingConstraint;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssociatesConstraint with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssociatesConstraint(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcDefinitionSelect> relatedObjects, IfcLabel intent,
            IfcConstraint relatingConstraint) : base(globalId, ownerHistory, name, description, relatedObjects)
        {
            Intent = intent;
            RelatingConstraint = relatingConstraint;
        }

        public IfcLabel Intent { get; set; } // optional
        public IfcConstraint RelatingConstraint { get; set; }

        public new static IfcRelAssociatesConstraint FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssociatesConstraint>(json);
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
                Intent != null ? Intent.ToStepValue() : "$",
                RelatingConstraint != null ? RelatingConstraint.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}