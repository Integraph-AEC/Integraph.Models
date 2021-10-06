using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterial.htm" />
	/// </summary>
	public class IfcMaterial : IfcMaterialDefinition
    {
	    /// <summary>
	    ///     Construct a IfcMaterial with all required attributes.
	    /// </summary>
	    public IfcMaterial(IfcLabel name)
        {
            HasRepresentation = new List<IfcMaterialDefinitionRepresentation>();
            IsRelatedWith = new List<IfcMaterialRelationship>();
            RelatesTo = new List<IfcMaterialRelationship>();

            Name = name;
        }

	    /// <summary>
	    ///     Construct a IfcMaterial with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterial(IfcLabel name, IfcText description, IfcLabel category)
        {
            HasRepresentation = new List<IfcMaterialDefinitionRepresentation>();
            IsRelatedWith = new List<IfcMaterialRelationship>();
            RelatesTo = new List<IfcMaterialRelationship>();

            Name = name;
            Description = description;
            Category = category;
        }

        public IfcLabel Name { get; set; }
        public IfcText Description { get; set; } // optional
        public IfcLabel Category { get; set; } // optional
        public List<IfcMaterialDefinitionRepresentation> HasRepresentation { get; set; } // inverse
        public List<IfcMaterialRelationship> IsRelatedWith { get; set; } // inverse
        public List<IfcMaterialRelationship> RelatesTo { get; set; } // inverse

        public new static IfcMaterial FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterial>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Category != null ? Category.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}