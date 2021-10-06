using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelconnectswitheccentricity.htm" />
	/// </summary>
	public class IfcRelConnectsWithEccentricity : IfcRelConnectsStructuralMember
    {
	    /// <summary>
	    ///     Construct a IfcRelConnectsWithEccentricity with all required attributes.
	    /// </summary>
	    public IfcRelConnectsWithEccentricity(IfcGloballyUniqueId globalId,
            IfcStructuralMember relatingStructuralMember, IfcStructuralConnection relatedStructuralConnection,
            IfcConnectionGeometry connectionConstraint) : base(globalId, relatingStructuralMember,
            relatedStructuralConnection)
        {
            ConnectionConstraint = connectionConstraint;
        }

	    /// <summary>
	    ///     Construct a IfcRelConnectsWithEccentricity with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelConnectsWithEccentricity(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcStructuralMember relatingStructuralMember,
            IfcStructuralConnection relatedStructuralConnection, IfcBoundaryCondition appliedCondition,
            IfcStructuralConnectionCondition additionalConditions, IfcLengthMeasure supportedLength,
            IfcAxis2Placement3D conditionCoordinateSystem, IfcConnectionGeometry connectionConstraint) : base(globalId,
            ownerHistory, name, description, relatingStructuralMember, relatedStructuralConnection, appliedCondition,
            additionalConditions, supportedLength, conditionCoordinateSystem)
        {
            ConnectionConstraint = connectionConstraint;
        }

        public IfcConnectionGeometry ConnectionConstraint { get; set; }

        public new static IfcRelConnectsWithEccentricity FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelConnectsWithEccentricity>(json);
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
                ConditionCoordinateSystem != null ? ConditionCoordinateSystem.ToStepValue() : "$",
                ConnectionConstraint != null ? ConnectionConstraint.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}