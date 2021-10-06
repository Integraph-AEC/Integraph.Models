using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassignstoproduct.htm" />
	/// </summary>
	public class IfcRelAssignsToProduct : IfcRelAssigns
    {
	    /// <summary>
	    ///     Construct a IfcRelAssignsToProduct with all required attributes.
	    /// </summary>
	    public IfcRelAssignsToProduct(IfcGloballyUniqueId globalId, List<IfcObjectDefinition> relatedObjects,
            IfcProductSelect relatingProduct) : base(globalId, relatedObjects)
        {
            RelatingProduct = relatingProduct;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssignsToProduct with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssignsToProduct(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcObjectDefinition> relatedObjects, IfcObjectTypeEnum relatedObjectsType,
            IfcProductSelect relatingProduct) : base(globalId, ownerHistory, name, description, relatedObjects,
            relatedObjectsType)
        {
            RelatingProduct = relatingProduct;
        }

        public IfcProductSelect RelatingProduct { get; set; }

        public new static IfcRelAssignsToProduct FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssignsToProduct>(json);
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
                RelatedObjectsType.ToStepValue(),
                RelatingProduct != null ? RelatingProduct.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}