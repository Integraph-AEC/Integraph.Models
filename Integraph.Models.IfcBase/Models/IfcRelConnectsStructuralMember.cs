using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelconnectsstructuralmember.htm" />
	/// </summary>
	public class IfcRelConnectsStructuralMember : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelConnectsStructuralMember with all required attributes.
	    /// </summary>
	    public IfcRelConnectsStructuralMember(IfcGloballyUniqueId globalId,
            IfcStructuralMember relatingStructuralMember,
            IfcStructuralConnection relatedStructuralConnection) : base(globalId)
        {
            RelatingStructuralMember = relatingStructuralMember;
            RelatedStructuralConnection = relatedStructuralConnection;
        }

	    /// <summary>
	    ///     Construct a IfcRelConnectsStructuralMember with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelConnectsStructuralMember(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcStructuralMember relatingStructuralMember,
            IfcStructuralConnection relatedStructuralConnection, IfcBoundaryCondition appliedCondition,
            IfcStructuralConnectionCondition additionalConditions, IfcLengthMeasure supportedLength,
            IfcAxis2Placement3D conditionCoordinateSystem) : base(globalId, ownerHistory, name, description)
        {
            RelatingStructuralMember = relatingStructuralMember;
            RelatedStructuralConnection = relatedStructuralConnection;
            AppliedCondition = appliedCondition;
            AdditionalConditions = additionalConditions;
            SupportedLength = supportedLength;
            ConditionCoordinateSystem = conditionCoordinateSystem;
        }

        public IfcStructuralMember RelatingStructuralMember { get; set; }
        public IfcStructuralConnection RelatedStructuralConnection { get; set; }
        public IfcBoundaryCondition AppliedCondition { get; set; } // optional
        public IfcStructuralConnectionCondition AdditionalConditions { get; set; } // optional
        public IfcLengthMeasure SupportedLength { get; set; } // optional
        public IfcAxis2Placement3D ConditionCoordinateSystem { get; set; } // optional

        public new static IfcRelConnectsStructuralMember FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelConnectsStructuralMember>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingStructuralMember != null ? RelatingStructuralMember.ToStepValue() : "$",
                RelatedStructuralConnection != null ? RelatedStructuralConnection.ToStepValue() : "$",
                AppliedCondition != null ? AppliedCondition.ToStepValue() : "$",
                AdditionalConditions != null ? AdditionalConditions.ToStepValue() : "$",
                SupportedLength != null ? SupportedLength.ToStepValue() : "$",
                ConditionCoordinateSystem != null ? ConditionCoordinateSystem.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}