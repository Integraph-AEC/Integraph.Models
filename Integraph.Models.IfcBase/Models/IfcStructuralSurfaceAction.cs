using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralsurfaceaction.htm" />
	/// </summary>
	public class IfcStructuralSurfaceAction : IfcStructuralAction
    {
	    /// <summary>
	    ///     Construct a IfcStructuralSurfaceAction with all required attributes.
	    /// </summary>
	    public IfcStructuralSurfaceAction(IfcGloballyUniqueId globalId, IfcStructuralLoad appliedLoad,
            IfcGlobalOrLocalEnum globalOrLocal, IfcStructuralSurfaceActivityTypeEnum predefinedType) : base(globalId,
            appliedLoad, globalOrLocal)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcStructuralSurfaceAction with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralSurfaceAction(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal,
            IfcBoolean destabilizingLoad, IfcProjectedOrTrueLengthEnum projectedOrTrue,
            IfcStructuralSurfaceActivityTypeEnum predefinedType) : base(globalId, ownerHistory, name, description,
            objectType, objectPlacement, representation, appliedLoad, globalOrLocal, destabilizingLoad)
        {
            ProjectedOrTrue = projectedOrTrue;
            PredefinedType = predefinedType;
        }

        public IfcProjectedOrTrueLengthEnum? ProjectedOrTrue { get; set; } // optional
        public IfcStructuralSurfaceActivityTypeEnum? PredefinedType { get; set; }

        public new static IfcStructuralSurfaceAction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralSurfaceAction>(json);
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
                DestabilizingLoad != null ? DestabilizingLoad.ToStepValue() : "$",
                ProjectedOrTrue.ToStepValue(),
                PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}