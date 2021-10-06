using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassociatesmaterial.htm" />
	/// </summary>
	public class IfcRelAssociatesMaterial : IfcRelAssociates
    {
	    /// <summary>
	    ///     Construct a IfcRelAssociatesMaterial with all required attributes.
	    /// </summary>
	    public IfcRelAssociatesMaterial(IfcGloballyUniqueId globalId, List<IfcDefinitionSelect> relatedObjects,
            IfcMaterialSelect relatingMaterial) : base(globalId, relatedObjects)
        {
            RelatingMaterial = relatingMaterial;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssociatesMaterial with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssociatesMaterial(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcDefinitionSelect> relatedObjects, IfcMaterialSelect relatingMaterial) : base(
            globalId, ownerHistory, name, description, relatedObjects)
        {
            RelatingMaterial = relatingMaterial;
        }

        public IfcMaterialSelect RelatingMaterial { get; set; }

        public new static IfcRelAssociatesMaterial FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssociatesMaterial>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatedObjects != null ? RelatedObjects.ToStepValue() : "$",
                RelatingMaterial != null ? RelatingMaterial.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}