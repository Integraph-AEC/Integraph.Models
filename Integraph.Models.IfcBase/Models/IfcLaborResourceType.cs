using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclaborresourcetype.htm" />
	/// </summary>
	public class IfcLaborResourceType : IfcConstructionResourceType
    {
	    /// <summary>
	    ///     Construct a IfcLaborResourceType with all required attributes.
	    /// </summary>
	    public IfcLaborResourceType(IfcGloballyUniqueId globalId, IfcLaborResourceTypeEnum predefinedType) :
            base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcLaborResourceType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLaborResourceType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            IfcIdentifier identification, IfcText longDescription, IfcLabel resourceType,
            List<IfcAppliedValue> baseCosts, IfcPhysicalQuantity baseQuantity, IfcLaborResourceTypeEnum predefinedType)
            : base(globalId, ownerHistory, name, description, applicableOccurrence, hasPropertySets, identification,
                longDescription, resourceType, baseCosts, baseQuantity)
        {
            PredefinedType = predefinedType;
        }

        public IfcLaborResourceTypeEnum? PredefinedType { get; set; }

        public new static IfcLaborResourceType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLaborResourceType>(json);
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