using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrectangulartrimmedsurface.htm" />
	/// </summary>
	public class IfcRectangularTrimmedSurface : IfcBoundedSurface
    {
	    /// <summary>
	    ///     Construct a IfcRectangularTrimmedSurface with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRectangularTrimmedSurface(IfcSurface basisSurface, IfcParameterValue u1, IfcParameterValue v1,
            IfcParameterValue u2, IfcParameterValue v2, IfcBoolean usense, IfcBoolean vsense)
        {
            BasisSurface = basisSurface;
            U1 = u1;
            V1 = v1;
            U2 = u2;
            V2 = v2;
            Usense = usense;
            Vsense = vsense;
        }

        public IfcSurface BasisSurface { get; set; }
        public IfcParameterValue U1 { get; set; }
        public IfcParameterValue V1 { get; set; }
        public IfcParameterValue U2 { get; set; }
        public IfcParameterValue V2 { get; set; }
        public IfcBoolean Usense { get; set; }
        public IfcBoolean Vsense { get; set; }

        public new static IfcRectangularTrimmedSurface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRectangularTrimmedSurface>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                BasisSurface != null ? BasisSurface.ToStepValue() : "$",
                U1 != null ? U1.ToStepValue() : "$",
                V1 != null ? V1.ToStepValue() : "$",
                U2 != null ? U2.ToStepValue() : "$",
                V2 != null ? V2.ToStepValue() : "$",
                Usense != null ? Usense.ToStepValue() : "$",
                Vsense != null ? Vsense.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}