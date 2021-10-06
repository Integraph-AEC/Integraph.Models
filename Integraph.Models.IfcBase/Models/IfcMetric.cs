using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmetric.htm" />
	/// </summary>
	public class IfcMetric : IfcConstraint
    {
	    /// <summary>
	    ///     Construct a IfcMetric with all required attributes.
	    /// </summary>
	    public IfcMetric(IfcLabel name, IfcConstraintEnum constraintGrade, IfcBenchmarkEnum benchmark) : base(name,
            constraintGrade)
        {
            Benchmark = benchmark;
        }

	    /// <summary>
	    ///     Construct a IfcMetric with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMetric(IfcLabel name, IfcText description, IfcConstraintEnum constraintGrade,
            IfcLabel constraintSource, IfcActorSelect creatingActor, IfcDateTime creationTime,
            IfcLabel userDefinedGrade, IfcBenchmarkEnum benchmark, IfcLabel valueSource, IfcMetricValueSelect dataValue,
            IfcReference referencePath) : base(name, description, constraintGrade, constraintSource, creatingActor,
            creationTime, userDefinedGrade)
        {
            Benchmark = benchmark;
            ValueSource = valueSource;
            DataValue = dataValue;
            ReferencePath = referencePath;
        }

        public IfcBenchmarkEnum? Benchmark { get; set; }
        public IfcLabel ValueSource { get; set; } // optional
        public IfcMetricValueSelect DataValue { get; set; } // optional
        public IfcReference ReferencePath { get; set; } // optional

        public new static IfcMetric FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMetric>(json);
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
                Benchmark.ToStepValue(),
                ValueSource != null ? ValueSource.ToStepValue() : "$",
                DataValue != null ? DataValue.ToStepValue() : "$",
                ReferencePath != null ? ReferencePath.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}