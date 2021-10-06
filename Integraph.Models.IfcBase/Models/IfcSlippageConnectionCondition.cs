using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcslippageconnectioncondition.htm" />
	/// </summary>
	public class IfcSlippageConnectionCondition : IfcStructuralConnectionCondition
    {
	    /// <summary>
	    ///     Construct a IfcSlippageConnectionCondition with all required attributes.
	    /// </summary>
	    public IfcSlippageConnectionCondition()
        {
        }

	    /// <summary>
	    ///     Construct a IfcSlippageConnectionCondition with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSlippageConnectionCondition(IfcLabel name, IfcLengthMeasure slippageX, IfcLengthMeasure slippageY,
            IfcLengthMeasure slippageZ) : base(name)
        {
            SlippageX = slippageX;
            SlippageY = slippageY;
            SlippageZ = slippageZ;
        }

        public IfcLengthMeasure SlippageX { get; set; } // optional
        public IfcLengthMeasure SlippageY { get; set; } // optional
        public IfcLengthMeasure SlippageZ { get; set; } // optional

        public new static IfcSlippageConnectionCondition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSlippageConnectionCondition>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            SlippageX != null ? SlippageX.ToStepValue() : "$",
	            SlippageY != null ? SlippageY.ToStepValue() : "$",
	            SlippageZ != null ? SlippageZ.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}