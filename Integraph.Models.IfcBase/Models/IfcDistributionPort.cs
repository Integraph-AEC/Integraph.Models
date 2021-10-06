using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdistributionport.htm" />
	/// </summary>
	public class IfcDistributionPort : IfcPort
    {
	    /// <summary>
	    ///     Construct a IfcDistributionPort with all required attributes.
	    /// </summary>
	    public IfcDistributionPort(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcDistributionPort with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDistributionPort(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcFlowDirectionEnum flowDirection,
            IfcDistributionPortTypeEnum predefinedType, IfcDistributionSystemEnum systemType) : base(globalId,
            ownerHistory, name, description, objectType, objectPlacement, representation)
        {
            FlowDirection = flowDirection;
            PredefinedType = predefinedType;
            SystemType = systemType;
        }

        public IfcFlowDirectionEnum? FlowDirection { get; set; } // optional
        public IfcDistributionPortTypeEnum? PredefinedType { get; set; } // optional
        public IfcDistributionSystemEnum? SystemType { get; set; } // optional

        public new static IfcDistributionPort FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDistributionPort>(json);
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
	            FlowDirection.ToStepValue(),
	            PredefinedType.ToStepValue(),
	            SystemType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}