using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralsurfacemember.htm" />
	/// </summary>
	public class IfcStructuralSurfaceMember : IfcStructuralMember
    {
	    /// <summary>
	    ///     Construct a IfcStructuralSurfaceMember with all required attributes.
	    /// </summary>
	    public IfcStructuralSurfaceMember(IfcGloballyUniqueId globalId,
            IfcStructuralSurfaceMemberTypeEnum predefinedType) : base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcStructuralSurfaceMember with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralSurfaceMember(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcStructuralSurfaceMemberTypeEnum predefinedType,
            IfcPositiveLengthMeasure thickness) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation)
        {
            PredefinedType = predefinedType;
            Thickness = thickness;
        }

        public IfcStructuralSurfaceMemberTypeEnum? PredefinedType { get; set; }
        public IfcPositiveLengthMeasure Thickness { get; set; } // optional

        public new static IfcStructuralSurfaceMember FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralSurfaceMember>(json);
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