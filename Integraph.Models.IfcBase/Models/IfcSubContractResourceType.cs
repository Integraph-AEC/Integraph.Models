using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsubcontractresourcetype.htm" />
	/// </summary>
	public class IfcSubContractResourceType : IfcConstructionResourceType
    {
	    /// <summary>
	    ///     Construct a IfcSubContractResourceType with all required attributes.
	    /// </summary>
	    public IfcSubContractResourceType(IfcGloballyUniqueId globalId, IfcSubContractResourceTypeEnum predefinedType) :
            base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcSubContractResourceType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSubContractResourceType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            IfcIdentifier identification, IfcText longDescription, IfcLabel resourceType,
            List<IfcAppliedValue> baseCosts, IfcPhysicalQuantity baseQuantity,
            IfcSubContractResourceTypeEnum predefinedType) : base(globalId, ownerHistory, name, description,
            applicableOccurrence, hasPropertySets, identification, longDescription, resourceType, baseCosts,
            baseQuantity)
        {
            PredefinedType = predefinedType;
        }

        public IfcSubContractResourceTypeEnum? PredefinedType { get; set; }

        public new static IfcSubContractResourceType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSubContractResourceType>(json);
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