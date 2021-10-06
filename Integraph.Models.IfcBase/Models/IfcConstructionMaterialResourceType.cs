using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconstructionmaterialresourcetype.htm" />
	/// </summary>
	public class IfcConstructionMaterialResourceType : IfcConstructionResourceType
    {
	    /// <summary>
	    ///     Construct a IfcConstructionMaterialResourceType with all required attributes.
	    /// </summary>
	    public IfcConstructionMaterialResourceType(IfcGloballyUniqueId globalId,
            IfcConstructionMaterialResourceTypeEnum predefinedType) : base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcConstructionMaterialResourceType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConstructionMaterialResourceType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory,
            IfcLabel name, IfcText description, IfcIdentifier applicableOccurrence,
            List<IfcPropertySetDefinition> hasPropertySets, IfcIdentifier identification, IfcText longDescription,
            IfcLabel resourceType, List<IfcAppliedValue> baseCosts, IfcPhysicalQuantity baseQuantity,
            IfcConstructionMaterialResourceTypeEnum predefinedType) : base(globalId, ownerHistory, name, description,
            applicableOccurrence, hasPropertySets, identification, longDescription, resourceType, baseCosts,
            baseQuantity)
        {
            PredefinedType = predefinedType;
        }

        public IfcConstructionMaterialResourceTypeEnum? PredefinedType { get; set; }

        public new static IfcConstructionMaterialResourceType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConstructionMaterialResourceType>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                ApplicableOccurrence != null ? ApplicableOccurrence.ToStepValue() : "$",
                HasPropertySets != null ? HasPropertySets.ToStepValue() : "$",
                Identification != null ? Identification.ToStepValue() : "$",
                LongDescription != null ? LongDescription.ToStepValue() : "$",
                ResourceType != null ? ResourceType.ToStepValue() : "$",
                BaseCosts != null ? BaseCosts.ToStepValue() : "$",
                BaseQuantity != null ? BaseQuantity.ToStepValue() : "$",
                PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}