using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralcurvereaction.htm" />
	/// </summary>
	public class IfcStructuralCurveReaction : IfcStructuralReaction
    {
	    /// <summary>
	    ///     Construct a IfcStructuralCurveReaction with all required attributes.
	    /// </summary>
	    public IfcStructuralCurveReaction(IfcGloballyUniqueId globalId, IfcStructuralLoad appliedLoad,
            IfcGlobalOrLocalEnum globalOrLocal, IfcStructuralCurveActivityTypeEnum predefinedType) : base(globalId,
            appliedLoad, globalOrLocal)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcStructuralCurveReaction with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralCurveReaction(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal,
            IfcStructuralCurveActivityTypeEnum predefinedType) : base(globalId, ownerHistory, name, description,
            objectType, objectPlacement, representation, appliedLoad, globalOrLocal)
        {
            PredefinedType = predefinedType;
        }

        public IfcStructuralCurveActivityTypeEnum? PredefinedType { get; set; }

        public new static IfcStructuralCurveReaction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralCurveReaction>(json);
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
                AppliedLoad != null ? AppliedLoad.ToStepValue() : "$",
                GlobalOrLocal.ToStepValue(),
                PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}