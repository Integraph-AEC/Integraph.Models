using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralsurfacemembervarying.htm" />
	/// </summary>
	public class IfcStructuralSurfaceMemberVarying : IfcStructuralSurfaceMember
    {
	    /// <summary>
	    ///     Construct a IfcStructuralSurfaceMemberVarying with all required attributes.
	    /// </summary>
	    public IfcStructuralSurfaceMemberVarying(IfcGloballyUniqueId globalId,
            IfcStructuralSurfaceMemberTypeEnum predefinedType) : base(globalId, predefinedType)
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralSurfaceMemberVarying with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralSurfaceMemberVarying(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory,
            IfcLabel name, IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcStructuralSurfaceMemberTypeEnum predefinedType,
            IfcPositiveLengthMeasure thickness) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation, predefinedType, thickness)
        {
        }

        public new static IfcStructuralSurfaceMemberVarying FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralSurfaceMemberVarying>(json);
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
	            Thickness != null ? Thickness.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}