using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralresultgroup.htm" />
	/// </summary>
	public class IfcStructuralResultGroup : IfcGroup
    {
	    /// <summary>
	    ///     Construct a IfcStructuralResultGroup with all required attributes.
	    /// </summary>
	    public IfcStructuralResultGroup(IfcGloballyUniqueId globalId, IfcAnalysisTheoryTypeEnum theoryType,
            IfcBoolean isLinear) : base(globalId)
        {
            ResultGroupFor = new List<IfcStructuralAnalysisModel>();

            TheoryType = theoryType;
            IsLinear = isLinear;
        }

	    /// <summary>
	    ///     Construct a IfcStructuralResultGroup with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralResultGroup(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcAnalysisTheoryTypeEnum theoryType,
            IfcStructuralLoadGroup resultForLoadGroup, IfcBoolean isLinear) : base(globalId, ownerHistory, name,
            description, objectType)
        {
            ResultGroupFor = new List<IfcStructuralAnalysisModel>();

            TheoryType = theoryType;
            ResultForLoadGroup = resultForLoadGroup;
            IsLinear = isLinear;
        }

        public IfcAnalysisTheoryTypeEnum? TheoryType { get; set; }
        public IfcStructuralLoadGroup ResultForLoadGroup { get; set; } // optional
        public IfcBoolean IsLinear { get; set; }
        public List<IfcStructuralAnalysisModel> ResultGroupFor { get; set; } // inverse

        public new static IfcStructuralResultGroup FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralResultGroup>(json);
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
                TheoryType.ToStepValue(),
                ResultForLoadGroup != null ? ResultForLoadGroup.ToStepValue() : "$",
                IsLinear != null ? IsLinear.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}