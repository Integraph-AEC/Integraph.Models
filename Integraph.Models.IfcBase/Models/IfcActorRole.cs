using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcactorrole.htm" />
	/// </summary>
	public class IfcActorRole : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcActorRole with all required attributes.
	    /// </summary>
	    public IfcActorRole(IfcRoleEnum role)
        {
            HasExternalReference = new List<IfcExternalReferenceRelationship>();

            Role = role;
        }

	    /// <summary>
	    ///     Construct a IfcActorRole with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcActorRole(IfcRoleEnum role, IfcLabel userDefinedRole, IfcText description)
        {
            HasExternalReference = new List<IfcExternalReferenceRelationship>();

            Role = role;
            UserDefinedRole = userDefinedRole;
            Description = description;
        }

        public IfcRoleEnum? Role { get; set; }
        public IfcLabel UserDefinedRole { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public List<IfcExternalReferenceRelationship> HasExternalReference { get; set; } // inverse

        public static IfcActorRole FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcActorRole>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Role.ToStepValue(),
	            UserDefinedRole != null ? UserDefinedRole.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}