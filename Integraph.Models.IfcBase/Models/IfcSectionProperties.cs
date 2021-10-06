using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsectionproperties.htm" />
	/// </summary>
	public class IfcSectionProperties : IfcPreDefinedProperties
    {
	    /// <summary>
	    ///     Construct a IfcSectionProperties with all required attributes.
	    /// </summary>
	    public IfcSectionProperties(IfcSectionTypeEnum sectionType, IfcProfileDef startProfile)
        {
            SectionType = sectionType;
            StartProfile = startProfile;
        }

	    /// <summary>
	    ///     Construct a IfcSectionProperties with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSectionProperties(IfcSectionTypeEnum sectionType, IfcProfileDef startProfile,
            IfcProfileDef endProfile)
        {
            SectionType = sectionType;
            StartProfile = startProfile;
            EndProfile = endProfile;
        }

        public IfcSectionTypeEnum? SectionType { get; set; }
        public IfcProfileDef StartProfile { get; set; }
        public IfcProfileDef EndProfile { get; set; } // optional

        public new static IfcSectionProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSectionProperties>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            SectionType.ToStepValue(),
	            StartProfile != null ? StartProfile.ToStepValue() : "$",
	            EndProfile != null ? EndProfile.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}