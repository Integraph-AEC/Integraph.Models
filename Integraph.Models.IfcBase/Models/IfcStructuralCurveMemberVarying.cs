using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralcurvemembervarying.htm" />
	/// </summary>
	public class IfcStructuralCurveMemberVarying : IfcStructuralCurveMember
    {
	    /// <summary>
	    ///     Construct a IfcStructuralCurveMemberVarying with all required attributes.
	    /// </summary>
	    public IfcStructuralCurveMemberVarying(IfcGloballyUniqueId globalId,
            IfcStructuralCurveMemberTypeEnum predefinedType, IfcDirection axis) : base(globalId, predefinedType, axis)
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralCurveMemberVarying with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralCurveMemberVarying(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory,
            IfcLabel name, IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcStructuralCurveMemberTypeEnum predefinedType, IfcDirection axis)
            : base(globalId, ownerHistory, name, description, objectType, objectPlacement, representation,
                predefinedType, axis)
        {
        }

        public new static IfcStructuralCurveMemberVarying FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralCurveMemberVarying>(json);
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
	            PredefinedType.ToStepValue(),
	            Axis != null ? Axis.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}