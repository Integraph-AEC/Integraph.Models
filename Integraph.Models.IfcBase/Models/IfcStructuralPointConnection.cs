using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralpointconnection.htm" />
	/// </summary>
	public class IfcStructuralPointConnection : IfcStructuralConnection
    {
	    /// <summary>
	    ///     Construct a IfcStructuralPointConnection with all required attributes.
	    /// </summary>
	    public IfcStructuralPointConnection(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralPointConnection with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralPointConnection(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcBoundaryCondition appliedCondition,
            IfcAxis2Placement3D conditionCoordinateSystem) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation, appliedCondition)
        {
            ConditionCoordinateSystem = conditionCoordinateSystem;
        }

        public IfcAxis2Placement3D ConditionCoordinateSystem { get; set; } // optional

        public new static IfcStructuralPointConnection FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralPointConnection>(json);
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
	            AppliedCondition != null ? AppliedCondition.ToStepValue() : "$",
	            ConditionCoordinateSystem != null ? ConditionCoordinateSystem.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}