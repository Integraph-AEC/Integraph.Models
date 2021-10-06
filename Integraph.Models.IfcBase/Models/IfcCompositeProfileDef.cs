using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccompositeprofiledef.htm" />
	/// </summary>
	public class IfcCompositeProfileDef : IfcProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcCompositeProfileDef with all required attributes.
	    /// </summary>
	    public IfcCompositeProfileDef(IfcProfileTypeEnum profileType, List<IfcProfileDef> profiles) : base(profileType)
        {
            Profiles = profiles;
        }

	    /// <summary>
	    ///     Construct a IfcCompositeProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCompositeProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName,
            List<IfcProfileDef> profiles, IfcLabel label) : base(profileType, profileName)
        {
            Profiles = profiles;
            Label = label;
        }

        public List<IfcProfileDef> Profiles { get; set; }
        public IfcLabel Label { get; set; } // optional

        public new static IfcCompositeProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCompositeProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            ProfileType.ToStepValue(),
	            ProfileName != null ? ProfileName.ToStepValue() : "$",
	            Profiles != null ? Profiles.ToStepValue() : "$",
	            Label != null ? Label.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}