using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcellipse.htm" />
	/// </summary>
	public class IfcEllipse : IfcConic
    {
	    /// <summary>
	    ///     Construct a IfcEllipse with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcEllipse(IfcAxis2Placement position, IfcPositiveLengthMeasure semiAxis1,
            IfcPositiveLengthMeasure semiAxis2) : base(position)
        {
            SemiAxis1 = semiAxis1;
            SemiAxis2 = semiAxis2;
        }

        public IfcPositiveLengthMeasure SemiAxis1 { get; set; }
        public IfcPositiveLengthMeasure SemiAxis2 { get; set; }

        public new static IfcEllipse FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcEllipse>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Position != null ? Position.ToStepValue() : "$",
                SemiAxis1 != null ? SemiAxis1.ToStepValue() : "$",
                SemiAxis2 != null ? SemiAxis2.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}