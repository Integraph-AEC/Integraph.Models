using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialprofile.htm" />
	/// </summary>
	public class IfcMaterialProfile : IfcMaterialDefinition
    {
	    /// <summary>
	    ///     Construct a IfcMaterialProfile with all required attributes.
	    /// </summary>
	    public IfcMaterialProfile(IfcProfileDef profile)
        {
            Profile = profile;
        }

	    /// <summary>
	    ///     Construct a IfcMaterialProfile with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialProfile(IfcLabel name, IfcText description, IfcMaterial material, IfcProfileDef profile,
            IfcInteger priority, IfcLabel category)
        {
            Name = name;
            Description = description;
            Material = material;
            Profile = profile;
            Priority = priority;
            Category = category;
        }

        public IfcLabel Name { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public IfcMaterial Material { get; set; } // optional
        public IfcProfileDef Profile { get; set; }
        public IfcInteger Priority { get; set; } // optional
        public IfcLabel Category { get; set; } // optional
        public IfcMaterialProfileSet ToMaterialProfileSet { get; set; } // inverse

        public new static IfcMaterialProfile FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialProfile>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Material != null ? Material.ToStepValue() : "$",
	            Profile != null ? Profile.ToStepValue() : "$",
	            Priority != null ? Priority.ToStepValue() : "$",
	            Category != null ? Category.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}