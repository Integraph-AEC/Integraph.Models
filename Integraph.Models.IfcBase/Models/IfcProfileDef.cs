using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcprofiledef.htm" />
	/// </summary>
	public class IfcProfileDef : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcProfileDef with all required attributes.
	    /// </summary>
	    public IfcProfileDef(IfcProfileTypeEnum profileType)
        {
            HasExternalReference = new List<IfcExternalReferenceRelationship>();
            HasProperties = new List<IfcProfileProperties>();

            ProfileType = profileType;
        }

	    /// <summary>
	    ///     Construct a IfcProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName)
        {
            HasExternalReference = new List<IfcExternalReferenceRelationship>();
            HasProperties = new List<IfcProfileProperties>();

            ProfileType = profileType;
            ProfileName = profileName;
        }

        public IfcProfileTypeEnum? ProfileType { get; set; }
        public IfcLabel ProfileName { get; set; } // optional
        public List<IfcExternalReferenceRelationship> HasExternalReference { get; set; } // inverse
        public List<IfcProfileProperties> HasProperties { get; set; } // inverse

        public static IfcProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            ProfileType.ToStepValue(),
	            ProfileName != null ? ProfileName.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}