using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconstructionproductresourcetype.htm" />
	/// </summary>
	public class IfcConstructionProductResourceType : IfcConstructionResourceType
    {
	    /// <summary>
	    ///     Construct a IfcConstructionProductResourceType with all required attributes.
	    /// </summary>
	    public IfcConstructionProductResourceType(IfcGloballyUniqueId globalId,
            IfcConstructionProductResourceTypeEnum predefinedType) : base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcConstructionProductResourceType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConstructionProductResourceType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory,
            IfcLabel name, IfcText description, IfcIdentifier applicableOccurrence,
            List<IfcPropertySetDefinition> hasPropertySets, IfcIdentifier identification, IfcText longDescription,
            IfcLabel resourceType, List<IfcAppliedValue> baseCosts, IfcPhysicalQuantity baseQuantity,
            IfcConstructionProductResourceTypeEnum predefinedType) : base(globalId, ownerHistory, name, description,
            applicableOccurrence, hasPropertySets, identification, longDescription, resourceType, baseCosts,
            baseQuantity)
        {
            PredefinedType = predefinedType;
        }

        public IfcConstructionProductResourceTypeEnum? PredefinedType { get; set; }

        public new static IfcConstructionProductResourceType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConstructionProductResourceType>(json);
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