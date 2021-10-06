using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccostvalue.htm" />
	/// </summary>
	public class IfcCostValue : IfcAppliedValue
    {
	    /// <summary>
	    ///     Construct a IfcCostValue with all required attributes.
	    /// </summary>
	    public IfcCostValue()
        {
        }

	    /// <summary>
	    ///     Construct a IfcCostValue with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCostValue(IfcLabel name, IfcText description, IfcAppliedValueSelect appliedValue,
            IfcMeasureWithUnit unitBasis, IfcDate applicableDate, IfcDate fixedUntilDate, IfcLabel category,
            IfcLabel condition, IfcArithmeticOperatorEnum arithmeticOperator, List<IfcAppliedValue> components) : base(
            name, description, appliedValue, unitBasis, applicableDate, fixedUntilDate, category, condition,
            arithmeticOperator, components)
        {
        }

        public new static IfcCostValue FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCostValue>(json);
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