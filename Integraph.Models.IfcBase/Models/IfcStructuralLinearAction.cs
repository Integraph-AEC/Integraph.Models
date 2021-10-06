using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructurallinearaction.htm" />
	/// </summary>
	public class IfcStructuralLinearAction : IfcStructuralCurveAction
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLinearAction with all required attributes.
	    /// </summary>
	    public IfcStructuralLinearAction(IfcGloballyUniqueId globalId, IfcStructuralLoad appliedLoad,
            IfcGlobalOrLocalEnum globalOrLocal, IfcStructuralCurveActivityTypeEnum predefinedType) : base(globalId,
            appliedLoad, globalOrLocal, predefinedType)
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLinearAction with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLinearAction(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal,
            IfcBoolean destabilizingLoad, IfcProjectedOrTrueLengthEnum projectedOrTrue,
            IfcStructuralCurveActivityTypeEnum predefinedType) : base(globalId, ownerHistory, name, description,
            objectType, objectPlacement, representation, appliedLoad, globalOrLocal, destabilizingLoad, projectedOrTrue,
            predefinedType)
        {
        }

        public new static IfcStructuralLinearAction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLinearAction>(json);
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