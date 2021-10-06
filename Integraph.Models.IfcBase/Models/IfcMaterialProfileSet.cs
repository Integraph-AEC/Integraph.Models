using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialprofileset.htm" />
	/// </summary>
	public class IfcMaterialProfileSet : IfcMaterialDefinition
    {
	    /// <summary>
	    ///     Construct a IfcMaterialProfileSet with all required attributes.
	    /// </summary>
	    public IfcMaterialProfileSet(List<IfcMaterialProfile> materialProfiles)
        {
            MaterialProfiles = materialProfiles;
        }

	    /// <summary>
	    ///     Construct a IfcMaterialProfileSet with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialProfileSet(IfcLabel name, IfcText description, List<IfcMaterialProfile> materialProfiles,
            IfcCompositeProfileDef compositeProfile)
        {
            Name = name;
            Description = description;
            MaterialProfiles = materialProfiles;
            CompositeProfile = compositeProfile;
        }

        public IfcLabel Name { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public List<IfcMaterialProfile> MaterialProfiles { get; set; }
        public IfcCompositeProfileDef CompositeProfile { get; set; } // optional

        public new static IfcMaterialProfileSet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialProfileSet>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            MaterialProfiles != null ? MaterialProfiles.ToStepValue() : "$",
	            CompositeProfile != null ? CompositeProfile.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}