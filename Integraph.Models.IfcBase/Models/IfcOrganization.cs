using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcorganization.htm" />
	/// </summary>
	public class IfcOrganization : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcOrganization with all required attributes.
	    /// </summary>
	    public IfcOrganization(IfcLabel name)
        {
            Roles = new List<IfcActorRole>();
            Addresses = new List<IfcAddress>();
            IsRelatedBy = new List<IfcOrganizationRelationship>();
            Relates = new List<IfcOrganizationRelationship>();
            Engages = new List<IfcPersonAndOrganization>();

            Name = name;
        }

	    /// <summary>
	    ///     Construct a IfcOrganization with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcOrganization(IfcIdentifier identification, IfcLabel name, IfcText description,
            List<IfcActorRole> roles, List<IfcAddress> addresses)
        {
            IsRelatedBy = new List<IfcOrganizationRelationship>();
            Relates = new List<IfcOrganizationRelationship>();
            Engages = new List<IfcPersonAndOrganization>();

            Identification = identification;
            Name = name;
            Description = description;
            Roles = roles;
            Addresses = addresses;
        }

        public IfcIdentifier Identification { get; set; } // optional
        public IfcLabel Name { get; set; }
        public IfcText Description { get; set; } // optional
        public List<IfcActorRole> Roles { get; set; } // optional
        public List<IfcAddress> Addresses { get; set; } // optional
        public List<IfcOrganizationRelationship> IsRelatedBy { get; set; } // inverse
        public List<IfcOrganizationRelationship> Relates { get; set; } // inverse
        public List<IfcPersonAndOrganization> Engages { get; set; } // inverse

        public static IfcOrganization FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcOrganization>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Identification != null ? Identification.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Roles != null ? Roles.ToStepValue() : "$",
	            Addresses != null ? Addresses.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}