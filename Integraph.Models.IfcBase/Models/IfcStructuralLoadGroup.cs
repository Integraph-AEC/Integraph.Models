using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralloadgroup.htm" />
	/// </summary>
	public class IfcStructuralLoadGroup : IfcGroup
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLoadGroup with all required attributes.
	    /// </summary>
	    public IfcStructuralLoadGroup(IfcGloballyUniqueId globalId, IfcLoadGroupTypeEnum predefinedType,
            IfcActionTypeEnum actionType, IfcActionSourceTypeEnum actionSource) : base(globalId)
        {
            SourceOfResultGroup = new List<IfcStructuralResultGroup>();
            LoadGroupFor = new List<IfcStructuralAnalysisModel>();

            PredefinedType = predefinedType;
            ActionType = actionType;
            ActionSource = actionSource;
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLoadGroup with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLoadGroup(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcLoadGroupTypeEnum predefinedType, IfcActionTypeEnum actionType,
            IfcActionSourceTypeEnum actionSource, IfcRatioMeasure coefficient, IfcLabel purpose) : base(globalId,
            ownerHistory, name, description, objectType)
        {
            SourceOfResultGroup = new List<IfcStructuralResultGroup>();
            LoadGroupFor = new List<IfcStructuralAnalysisModel>();

            PredefinedType = predefinedType;
            ActionType = actionType;
            ActionSource = actionSource;
            Coefficient = coefficient;
            Purpose = purpose;
        }

        public IfcLoadGroupTypeEnum? PredefinedType { get; set; }
        public IfcActionTypeEnum? ActionType { get; set; }
        public IfcActionSourceTypeEnum? ActionSource { get; set; }
        public IfcRatioMeasure Coefficient { get; set; } // optional
        public IfcLabel Purpose { get; set; } // optional
        public List<IfcStructuralResultGroup> SourceOfResultGroup { get; set; } // inverse
        public List<IfcStructuralAnalysisModel> LoadGroupFor { get; set; } // inverse

        public new static IfcStructuralLoadGroup FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLoadGroup>(json);
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
                PredefinedType.ToStepValue(),
                ActionType.ToStepValue(),
                ActionSource.ToStepValue(),
                Coefficient != null ? Coefficient.ToStepValue() : "$",
                Purpose != null ? Purpose.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}