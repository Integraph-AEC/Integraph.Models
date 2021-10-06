using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcasset.htm" />
	/// </summary>
	public class IfcAsset : IfcGroup
    {
	    /// <summary>
	    ///     Construct a IfcAsset with all required attributes.
	    /// </summary>
	    public IfcAsset(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcAsset with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcAsset(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcIdentifier identification, IfcCostValue originalValue, IfcCostValue currentValue,
            IfcCostValue totalReplacementCost, IfcActorSelect owner, IfcActorSelect user, IfcPerson responsiblePerson,
            IfcDate incorporationDate, IfcCostValue depreciatedValue) : base(globalId, ownerHistory, name, description,
            objectType)
        {
            Identification = identification;
            OriginalValue = originalValue;
            CurrentValue = currentValue;
            TotalReplacementCost = totalReplacementCost;
            Owner = owner;
            User = user;
            ResponsiblePerson = responsiblePerson;
            IncorporationDate = incorporationDate;
            DepreciatedValue = depreciatedValue;
        }

        public IfcIdentifier Identification { get; set; } // optional
        public IfcCostValue OriginalValue { get; set; } // optional
        public IfcCostValue CurrentValue { get; set; } // optional
        public IfcCostValue TotalReplacementCost { get; set; } // optional
        public IfcActorSelect Owner { get; set; } // optional
        public IfcActorSelect User { get; set; } // optional
        public IfcPerson ResponsiblePerson { get; set; } // optional
        public IfcDate IncorporationDate { get; set; } // optional
        public IfcCostValue DepreciatedValue { get; set; } // optional

        public new static IfcAsset FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAsset>(json);
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
	            Identification != null ? Identification.ToStepValue() : "$",
	            OriginalValue != null ? OriginalValue.ToStepValue() : "$",
	            CurrentValue != null ? CurrentValue.ToStepValue() : "$",
	            TotalReplacementCost != null ? TotalReplacementCost.ToStepValue() : "$",
	            Owner != null ? Owner.ToStepValue() : "$",
	            User != null ? User.ToStepValue() : "$",
	            ResponsiblePerson != null ? ResponsiblePerson.ToStepValue() : "$",
	            IncorporationDate != null ? IncorporationDate.ToStepValue() : "$",
	            DepreciatedValue != null ? DepreciatedValue.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}