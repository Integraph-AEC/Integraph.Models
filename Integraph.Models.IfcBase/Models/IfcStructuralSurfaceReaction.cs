using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralsurfacereaction.htm" />
	/// </summary>
	public class IfcStructuralSurfaceReaction : IfcStructuralReaction
    {
	    /// <summary>
	    ///     Construct a IfcStructuralSurfaceReaction with all required attributes.
	    /// </summary>
	    public IfcStructuralSurfaceReaction(IfcGloballyUniqueId globalId, IfcStructuralLoad appliedLoad,
            IfcGlobalOrLocalEnum globalOrLocal, IfcStructuralSurfaceActivityTypeEnum predefinedType) : base(globalId,
            appliedLoad, globalOrLocal)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcStructuralSurfaceReaction with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralSurfaceReaction(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal,
            IfcStructuralSurfaceActivityTypeEnum predefinedType) : base(globalId, ownerHistory, name, description,
            objectType, objectPlacement, representation, appliedLoad, globalOrLocal)
        {
            PredefinedType = predefinedType;
        }

        public IfcStructuralSurfaceActivityTypeEnum? PredefinedType { get; set; }

        public new static IfcStructuralSurfaceReaction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralSurfaceReaction>(json);
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