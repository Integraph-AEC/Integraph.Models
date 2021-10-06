using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcinventory.htm" />
	/// </summary>
	public class IfcInventory : IfcGroup
    {
	    /// <summary>
	    ///     Construct a IfcInventory with all required attributes.
	    /// </summary>
	    public IfcInventory(IfcGloballyUniqueId globalId) : base(globalId)
        {
            ResponsiblePersons = new List<IfcPerson>();
        }

	    /// <summary>
	    ///     Construct a IfcInventory with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcInventory(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcInventoryTypeEnum predefinedType, IfcActorSelect jurisdiction,
            List<IfcPerson> responsiblePersons, IfcDate lastUpdateDate, IfcCostValue currentValue,
            IfcCostValue originalValue) : base(globalId, ownerHistory, name, description, objectType)
        {
            PredefinedType = predefinedType;
            Jurisdiction = jurisdiction;
            ResponsiblePersons = responsiblePersons;
            LastUpdateDate = lastUpdateDate;
            CurrentValue = currentValue;
            OriginalValue = originalValue;
        }

        public IfcInventoryTypeEnum? PredefinedType { get; set; } // optional
        public IfcActorSelect Jurisdiction { get; set; } // optional
        public List<IfcPerson> ResponsiblePersons { get; set; } // optional
        public IfcDate LastUpdateDate { get; set; } // optional
        public IfcCostValue CurrentValue { get; set; } // optional
        public IfcCostValue OriginalValue { get; set; } // optional

        public new static IfcInventory FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcInventory>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ObjectType != null ? ObjectType.ToStepValue() : "$",
	            PredefinedType.ToStepValue(),
	            Jurisdiction != null ? Jurisdiction.ToStepValue() : "$",
	            ResponsiblePersons != null ? ResponsiblePersons.ToStepValue() : "$",
	            LastUpdateDate != null ? LastUpdateDate.ToStepValue() : "$",
	            CurrentValue != null ? CurrentValue.ToStepValue() : "$",
	            OriginalValue != null ? OriginalValue.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}