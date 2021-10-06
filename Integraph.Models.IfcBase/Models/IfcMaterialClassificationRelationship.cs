using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialclassificationrelationship.htm" />
	/// </summary>
	public class IfcMaterialClassificationRelationship : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcMaterialClassificationRelationship with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialClassificationRelationship(List<IfcClassificationSelect> materialClassifications,
            IfcMaterial classifiedMaterial)
        {
            MaterialClassifications = materialClassifications;
            ClassifiedMaterial = classifiedMaterial;
        }

        public List<IfcClassificationSelect> MaterialClassifications { get; set; }
        public IfcMaterial ClassifiedMaterial { get; set; }

        public static IfcMaterialClassificationRelationship FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialClassificationRelationship>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                MaterialClassifications != null ? MaterialClassifications.ToStepValue() : "$",
                ClassifiedMaterial != null ? ClassifiedMaterial.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}