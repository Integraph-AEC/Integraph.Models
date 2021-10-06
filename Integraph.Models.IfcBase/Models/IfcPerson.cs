using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcperson.htm" />
	/// </summary>
	public class IfcPerson : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcPerson with all required attributes.
	    /// </summary>
	    public IfcPerson()
        {
            MiddleNames = new List<IfcLabel>();
            PrefixTitles = new List<IfcLabel>();
            SuffixTitles = new List<IfcLabel>();
            Roles = new List<IfcActorRole>();
            Addresses = new List<IfcAddress>();
            EngagedIn = new List<IfcPersonAndOrganization>();
        }

	    /// <summary>
	    ///     Construct a IfcPerson with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPerson(IfcIdentifier identification, IfcLabel familyName, IfcLabel givenName,
            List<IfcLabel> middleNames, List<IfcLabel> prefixTitles, List<IfcLabel> suffixTitles,
            List<IfcActorRole> roles, List<IfcAddress> addresses)
        {
            EngagedIn = new List<IfcPersonAndOrganization>();

            Identification = identification;
            FamilyName = familyName;
            GivenName = givenName;
            MiddleNames = middleNames;
            PrefixTitles = prefixTitles;
            SuffixTitles = suffixTitles;
            Roles = roles;
            Addresses = addresses;
        }

        public IfcIdentifier Identification { get; set; } // optional
        public IfcLabel FamilyName { get; set; } // optional
        public IfcLabel GivenName { get; set; } // optional
        public List<IfcLabel> MiddleNames { get; set; } // optional
        public List<IfcLabel> PrefixTitles { get; set; } // optional
        public List<IfcLabel> SuffixTitles { get; set; } // optional
        public List<IfcActorRole> Roles { get; set; } // optional
        public List<IfcAddress> Addresses { get; set; } // optional
        public List<IfcPersonAndOrganization> EngagedIn { get; set; } // inverse

        public static IfcPerson FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPerson>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Identification != null ? Identification.ToStepValue() : "$",
	            FamilyName != null ? FamilyName.ToStepValue() : "$",
	            GivenName != null ? GivenName.ToStepValue() : "$",
	            MiddleNames != null ? MiddleNames.ToStepValue() : "$",
	            PrefixTitles != null ? PrefixTitles.ToStepValue() : "$",
	            SuffixTitles != null ? SuffixTitles.ToStepValue() : "$",
	            Roles != null ? Roles.ToStepValue() : "$",
	            Addresses != null ? Addresses.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}