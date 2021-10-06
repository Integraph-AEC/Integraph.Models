using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcresourceconstraintrelationship.htm" />
	/// </summary>
	public class IfcResourceConstraintRelationship : IfcResourceLevelRelationship
    {
	    /// <summary>
	    ///     Construct a IfcResourceConstraintRelationship with all required attributes.
	    /// </summary>
	    public IfcResourceConstraintRelationship(IfcConstraint relatingConstraint,
            List<IfcResourceObjectSelect> relatedResourceObjects)
        {
            RelatingConstraint = relatingConstraint;
            RelatedResourceObjects = relatedResourceObjects;
        }

	    /// <summary>
	    ///     Construct a IfcResourceConstraintRelationship with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcResourceConstraintRelationship(IfcLabel name, IfcText description, IfcConstraint relatingConstraint,
            List<IfcResourceObjectSelect> relatedResourceObjects) : base(name, description)
        {
            RelatingConstraint = relatingConstraint;
            RelatedResourceObjects = relatedResourceObjects;
        }

        public IfcConstraint RelatingConstraint { get; set; }
        public List<IfcResourceObjectSelect> RelatedResourceObjects { get; set; }

        public new static IfcResourceConstraintRelationship FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcResourceConstraintRelationship>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingConstraint != null ? RelatingConstraint.ToStepValue() : "$",
                RelatedResourceObjects != null ? RelatedResourceObjects.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}