using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdistributionchamberelement.htm" />
	/// </summary>
	public class IfcDistributionChamberElement : IfcDistributionFlowElement
    {
	    /// <summary>
	    ///     Construct a IfcDistributionChamberElement with all required attributes.
	    /// </summary>
	    public IfcDistributionChamberElement(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcDistributionChamberElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDistributionChamberElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag,
            IfcDistributionChamberElementTypeEnum predefinedType) : base(globalId, ownerHistory, name, description,
            objectType, objectPlacement, representation, tag)
        {
            PredefinedType = predefinedType;
        }

        public IfcDistributionChamberElementTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcDistributionChamberElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDistributionChamberElement>(json);
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
	            ObjectPlacement != null ? ObjectPlacement.ToStepValue() : "$",
	            Representation != null ? Representation.ToStepValue() : "$",
	            Tag != null ? Tag.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}