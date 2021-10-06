using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbooleanclippingresult.htm" />
	/// </summary>
	public class IfcBooleanClippingResult : IfcBooleanResult
    {
	    /// <summary>
	    ///     Construct a IfcBooleanClippingResult with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBooleanClippingResult(IfcBooleanOperator op, IfcBooleanOperand firstOperand,
            IfcBooleanOperand secondOperand) : base(op, firstOperand, secondOperand)
        {
        }

        public new static IfcBooleanClippingResult FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBooleanClippingResult>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Operator != null ? Operator.ToStepValue() : "$",
	            FirstOperand != null ? FirstOperand.ToStepValue() : "$",
	            SecondOperand != null ? SecondOperand.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}