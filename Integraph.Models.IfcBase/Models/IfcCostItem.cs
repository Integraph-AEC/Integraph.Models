using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccostitem.htm" />
	/// </summary>
	public class IfcCostItem : IfcControl
    {
	    /// <summary>
	    ///     Construct a IfcCostItem with all required attributes.
	    /// </summary>
	    public IfcCostItem(IfcGloballyUniqueId globalId) : base(globalId)
        {
            CostValues = new List<IfcCostValue>();
            CostQuantities = new List<IfcPhysicalQuantity>();
        }

	    /// <summary>
	    ///     Construct a IfcCostItem with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCostItem(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcIdentifier identification, IfcCostItemTypeEnum predefinedType,
            List<IfcCostValue> costValues, List<IfcPhysicalQuantity> costQuantities) : base(globalId, ownerHistory,
            name, description, objectType, identification)
        {
            PredefinedType = predefinedType;
            CostValues = costValues;
            CostQuantities = costQuantities;
        }

        public IfcCostItemTypeEnum? PredefinedType { get; set; } // optional
        public List<IfcCostValue> CostValues { get; set; } // optional
        public List<IfcPhysicalQuantity> CostQuantities { get; set; } // optional

        public new static IfcCostItem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCostItem>(json);
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
	            PredefinedType.ToStepValue(),
	            CostValues != null ? CostValues.ToStepValue() : "$",
	            CostQuantities != null ? CostQuantities.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}