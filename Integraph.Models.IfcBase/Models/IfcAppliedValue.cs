using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcappliedvalue.htm" />
	/// </summary>
	public class IfcAppliedValue : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcAppliedValue with all required attributes.
	    /// </summary>
	    public IfcAppliedValue()
        {
            Components = new List<IfcAppliedValue>();
            HasExternalReference = new List<IfcExternalReferenceRelationship>();
        }

	    /// <summary>
	    ///     Construct a IfcAppliedValue with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcAppliedValue(IfcLabel name, IfcText description, IfcAppliedValueSelect appliedValue,
            IfcMeasureWithUnit unitBasis, IfcDate applicableDate, IfcDate fixedUntilDate, IfcLabel category,
            IfcLabel condition, IfcArithmeticOperatorEnum arithmeticOperator, List<IfcAppliedValue> components)
        {
            HasExternalReference = new List<IfcExternalReferenceRelationship>();

            Name = name;
            Description = description;
            AppliedValue = appliedValue;
            UnitBasis = unitBasis;
            ApplicableDate = applicableDate;
            FixedUntilDate = fixedUntilDate;
            Category = category;
            Condition = condition;
            ArithmeticOperator = arithmeticOperator;
            Components = components;
        }

        public IfcLabel Name { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public IfcAppliedValueSelect AppliedValue { get; set; } // optional
        public IfcMeasureWithUnit UnitBasis { get; set; } // optional
        public IfcDate ApplicableDate { get; set; } // optional
        public IfcDate FixedUntilDate { get; set; } // optional
        public IfcLabel Category { get; set; } // optional
        public IfcLabel Condition { get; set; } // optional
        public IfcArithmeticOperatorEnum? ArithmeticOperator { get; set; } // optional
        public List<IfcAppliedValue> Components { get; set; } // optional
        public List<IfcExternalReferenceRelationship> HasExternalReference { get; set; } // inverse

        public static IfcAppliedValue FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAppliedValue>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            AppliedValue != null ? AppliedValue.ToStepValue() : "$",
	            UnitBasis != null ? UnitBasis.ToStepValue() : "$",
	            ApplicableDate != null ? ApplicableDate.ToStepValue() : "$",
	            FixedUntilDate != null ? FixedUntilDate.ToStepValue() : "$",
	            Category != null ? Category.ToStepValue() : "$",
	            Condition != null ? Condition.ToStepValue() : "$",
	            ArithmeticOperator.ToStepValue(),
	            Components != null ? Components.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}