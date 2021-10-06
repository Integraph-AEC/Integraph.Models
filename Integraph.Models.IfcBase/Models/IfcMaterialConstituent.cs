using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialconstituent.htm" />
	/// </summary>
	public class IfcMaterialConstituent : IfcMaterialDefinition
    {
	    /// <summary>
	    ///     Construct a IfcMaterialConstituent with all required attributes.
	    /// </summary>
	    public IfcMaterialConstituent(IfcMaterial material)
        {
            Material = material;
        }

	    /// <summary>
	    ///     Construct a IfcMaterialConstituent with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialConstituent(IfcLabel name, IfcText description, IfcMaterial material,
            IfcNormalisedRatioMeasure fraction, IfcLabel category)
        {
            Name = name;
            Description = description;
            Material = material;
            Fraction = fraction;
            Category = category;
        }

        public IfcLabel Name { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public IfcMaterial Material { get; set; }
        public IfcNormalisedRatioMeasure Fraction { get; set; } // optional
        public IfcLabel Category { get; set; } // optional
        public IfcMaterialConstituentSet ToMaterialConstituentSet { get; set; } // inverse

        public new static IfcMaterialConstituent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialConstituent>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Material != null ? Material.ToStepValue() : "$",
	            Fraction != null ? Fraction.ToStepValue() : "$",
	            Category != null ? Category.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}