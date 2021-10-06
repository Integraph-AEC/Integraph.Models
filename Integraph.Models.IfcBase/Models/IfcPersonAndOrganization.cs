using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpersonandorganization.htm" />
	/// </summary>
	public class IfcPersonAndOrganization : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcPersonAndOrganization with all required attributes.
	    /// </summary>
	    public IfcPersonAndOrganization(IfcPerson thePerson, IfcOrganization theOrganization)
        {
            Roles = new List<IfcActorRole>();

            ThePerson = thePerson;
            TheOrganization = theOrganization;
        }

	    /// <summary>
	    ///     Construct a IfcPersonAndOrganization with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPersonAndOrganization(IfcPerson thePerson, IfcOrganization theOrganization, List<IfcActorRole> roles)
        {
            ThePerson = thePerson;
            TheOrganization = theOrganization;
            Roles = roles;
        }

        public IfcPerson ThePerson { get; set; }
        public IfcOrganization TheOrganization { get; set; }
        public List<IfcActorRole> Roles { get; set; } // optional

        public static IfcPersonAndOrganization FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPersonAndOrganization>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            ThePerson != null ? ThePerson.ToStepValue() : "$",
	            TheOrganization != null ? TheOrganization.ToStepValue() : "$",
	            Roles != null ? Roles.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}