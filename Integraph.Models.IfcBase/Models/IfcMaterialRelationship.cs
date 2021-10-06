using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialrelationship.htm" />
	/// </summary>
	public class IfcMaterialRelationship : IfcResourceLevelRelationship
    {
	    /// <summary>
	    ///     Construct a IfcMaterialRelationship with all required attributes.
	    /// </summary>
	    public IfcMaterialRelationship(IfcMaterial relatingMaterial, List<IfcMaterial> relatedMaterials)
        {
            RelatingMaterial = relatingMaterial;
            RelatedMaterials = relatedMaterials;
        }

	    /// <summary>
	    ///     Construct a IfcMaterialRelationship with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialRelationship(IfcLabel name, IfcText description, IfcMaterial relatingMaterial,
            List<IfcMaterial> relatedMaterials, IfcLabel expression) : base(name, description)
        {
            RelatingMaterial = relatingMaterial;
            RelatedMaterials = relatedMaterials;
            Expression = expression;
        }

        public IfcMaterial RelatingMaterial { get; set; }
        public List<IfcMaterial> RelatedMaterials { get; set; }
        public IfcLabel Expression { get; set; } // optional

        public new static IfcMaterialRelationship FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialRelationship>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            RelatingMaterial != null ? RelatingMaterial.ToStepValue() : "$",
	            RelatedMaterials != null ? RelatedMaterials.ToStepValue() : "$",
	            Expression != null ? Expression.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}