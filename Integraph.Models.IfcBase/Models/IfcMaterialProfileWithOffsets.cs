using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialprofilewithoffsets.htm" />
	/// </summary>
	public class IfcMaterialProfileWithOffsets : IfcMaterialProfile
    {
	    /// <summary>
	    ///     Construct a IfcMaterialProfileWithOffsets with all required attributes.
	    /// </summary>
	    public IfcMaterialProfileWithOffsets(IfcProfileDef profile, List<IfcLengthMeasure> offsetValues) : base(profile)
        {
            OffsetValues = offsetValues;
        }

	    /// <summary>
	    ///     Construct a IfcMaterialProfileWithOffsets with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialProfileWithOffsets(IfcLabel name, IfcText description, IfcMaterial material,
            IfcProfileDef profile, IfcInteger priority, IfcLabel category, List<IfcLengthMeasure> offsetValues) : base(
            name, description, material, profile, priority, category)
        {
            OffsetValues = offsetValues;
        }

        public List<IfcLengthMeasure> OffsetValues { get; set; }

        public new static IfcMaterialProfileWithOffsets FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialProfileWithOffsets>(json);
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
	            Category != null ? Category.ToStepValue() : "$",
	            OffsetValues != null ? OffsetValues.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}