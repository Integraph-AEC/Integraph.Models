using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbooleanresult.htm" />
	/// </summary>
	public class IfcBooleanResult : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcBooleanResult with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBooleanResult(IfcBooleanOperator op, IfcBooleanOperand firstOperand, IfcBooleanOperand secondOperand)
        {
            Operator = op;
            FirstOperand = firstOperand;
            SecondOperand = secondOperand;
        }

        public IfcBooleanOperator? Operator { get; set; }
        public IfcBooleanOperand FirstOperand { get; set; }
        public IfcBooleanOperand SecondOperand { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcBooleanResult FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBooleanResult>(json);
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