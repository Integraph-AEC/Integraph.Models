using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcoutlet.htm" />
	/// </summary>
	public class IfcOutlet : IfcFlowTerminal
    {
	    /// <summary>
	    ///     Construct a IfcOutlet with all required attributes.
	    /// </summary>
	    public IfcOutlet(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcOutlet with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcOutlet(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcObjectPlacement objectPlacement, IfcProductRepresentation representation,
            IfcIdentifier tag, IfcOutletTypeEnum predefinedType) : base(globalId, ownerHistory, name, description,
            objectType, objectPlacement, representation, tag)
        {
            PredefinedType = predefinedType;
        }

        public IfcOutletTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcOutlet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcOutlet>(json);
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