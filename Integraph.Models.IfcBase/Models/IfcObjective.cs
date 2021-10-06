using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcobjective.htm" />
	/// </summary>
	public class IfcObjective : IfcConstraint
    {
	    /// <summary>
	    ///     Construct a IfcObjective with all required attributes.
	    /// </summary>
	    public IfcObjective(IfcLabel name, IfcConstraintEnum constraintGrade, IfcObjectiveEnum objectiveQualifier) :
            base(name, constraintGrade)
        {
            BenchmarkValues = new List<IfcConstraint>();

            ObjectiveQualifier = objectiveQualifier;
        }

	    /// <summary>
	    ///     Construct a IfcObjective with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcObjective(IfcLabel name, IfcText description, IfcConstraintEnum constraintGrade,
            IfcLabel constraintSource, IfcActorSelect creatingActor, IfcDateTime creationTime,
            IfcLabel userDefinedGrade, List<IfcConstraint> benchmarkValues, IfcLogicalOperatorEnum logicalAggregator,
            IfcObjectiveEnum objectiveQualifier, IfcLabel userDefinedQualifier) : base(name, description,
            constraintGrade, constraintSource, creatingActor, creationTime, userDefinedGrade)
        {
            BenchmarkValues = benchmarkValues;
            LogicalAggregator = logicalAggregator;
            ObjectiveQualifier = objectiveQualifier;
            UserDefinedQualifier = userDefinedQualifier;
        }

        public List<IfcConstraint> BenchmarkValues { get; set; } // optional
        public IfcLogicalOperatorEnum? LogicalAggregator { get; set; } // optional
        public IfcObjectiveEnum? ObjectiveQualifier { get; set; }
        public IfcLabel UserDefinedQualifier { get; set; } // optional

        public new static IfcObjective FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcObjective>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                ConstraintGrade.ToStepValue(),
                ConstraintSource != null ? ConstraintSource.ToStepValue() : "$",
                CreatingActor != null ? CreatingActor.ToStepValue() : "$",
                CreationTime != null ? CreationTime.ToStepValue() : "$",
                UserDefinedGrade != null ? UserDefinedGrade.ToStepValue() : "$",
                BenchmarkValues != null ? BenchmarkValues.ToStepValue() : "$",
                LogicalAggregator.ToStepValue(),
                ObjectiveQualifier.ToStepValue(),
                UserDefinedQualifier != null ? UserDefinedQualifier.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}