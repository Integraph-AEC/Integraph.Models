using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralcurvemember.htm" />
	/// </summary>
	public class IfcStructuralCurveMember : IfcStructuralMember
    {
	    /// <summary>
	    ///     Construct a IfcStructuralCurveMember with all required attributes.
	    /// </summary>
	    public IfcStructuralCurveMember(IfcGloballyUniqueId globalId, IfcStructuralCurveMemberTypeEnum predefinedType,
            IfcDirection axis) : base(globalId)
        {
            PredefinedType = predefinedType;
            Axis = axis;
        }

	    /// <summary>
	    ///     Construct a IfcStructuralCurveMember with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralCurveMember(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcStructuralCurveMemberTypeEnum predefinedType, IfcDirection axis)
            : base(globalId, ownerHistory, name, description, objectType, objectPlacement, representation)
        {
            PredefinedType = predefinedType;
            Axis = axis;
        }

        public IfcStructuralCurveMemberTypeEnum? PredefinedType { get; set; }
        public IfcDirection Axis { get; set; }

        public new static IfcStructuralCurveMember FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralCurveMember>(json);
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