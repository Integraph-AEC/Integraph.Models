using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralcurveconnection.htm" />
	/// </summary>
	public class IfcStructuralCurveConnection : IfcStructuralConnection
    {
	    /// <summary>
	    ///     Construct a IfcStructuralCurveConnection with all required attributes.
	    /// </summary>
	    public IfcStructuralCurveConnection(IfcGloballyUniqueId globalId, IfcDirection axis) : base(globalId)
        {
            Axis = axis;
        }

	    /// <summary>
	    ///     Construct a IfcStructuralCurveConnection with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralCurveConnection(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcBoundaryCondition appliedCondition, IfcDirection axis) : base(
            globalId, ownerHistory, name, description, objectType, objectPlacement, representation, appliedCondition)
        {
            Axis = axis;
        }

        public IfcDirection Axis { get; set; }

        public new static IfcStructuralCurveConnection FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralCurveConnection>(json);
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
	            Axis != null ? Axis.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}