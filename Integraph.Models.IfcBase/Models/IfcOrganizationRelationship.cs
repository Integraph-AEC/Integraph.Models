using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcorganizationrelationship.htm" />
	/// </summary>
	public class IfcOrganizationRelationship : IfcResourceLevelRelationship
    {
	    /// <summary>
	    ///     Construct a IfcOrganizationRelationship with all required attributes.
	    /// </summary>
	    public IfcOrganizationRelationship(IfcOrganization relatingOrganization,
            List<IfcOrganization> relatedOrganizations)
        {
            RelatingOrganization = relatingOrganization;
            RelatedOrganizations = relatedOrganizations;
        }

	    /// <summary>
	    ///     Construct a IfcOrganizationRelationship with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcOrganizationRelationship(IfcLabel name, IfcText description, IfcOrganization relatingOrganization,
            List<IfcOrganization> relatedOrganizations) : base(name, description)
        {
            RelatingOrganization = relatingOrganization;
            RelatedOrganizations = relatedOrganizations;
        }

        public IfcOrganization RelatingOrganization { get; set; }
        public List<IfcOrganization> RelatedOrganizations { get; set; }

        public new static IfcOrganizationRelationship FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcOrganizationRelationship>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingOrganization != null ? RelatingOrganization.ToStepValue() : "$",
                RelatedOrganizations != null ? RelatedOrganizations.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}