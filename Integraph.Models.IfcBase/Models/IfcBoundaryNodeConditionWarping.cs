using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboundarynodeconditionwarping.htm" />
	/// </summary>
	public class IfcBoundaryNodeConditionWarping : IfcBoundaryNodeCondition
    {
	    /// <summary>
	    ///     Construct a IfcBoundaryNodeConditionWarping with all required attributes.
	    /// </summary>
	    public IfcBoundaryNodeConditionWarping()
        {
        }

	    /// <summary>
	    ///     Construct a IfcBoundaryNodeConditionWarping with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBoundaryNodeConditionWarping(IfcLabel name, IfcTranslationalStiffnessSelect translationalStiffnessX,
            IfcTranslationalStiffnessSelect translationalStiffnessY,
            IfcTranslationalStiffnessSelect translationalStiffnessZ, IfcRotationalStiffnessSelect rotationalStiffnessX,
            IfcRotationalStiffnessSelect rotationalStiffnessY, IfcRotationalStiffnessSelect rotationalStiffnessZ,
            IfcWarpingStiffnessSelect warpingStiffness) : base(name, translationalStiffnessX, translationalStiffnessY,
            translationalStiffnessZ, rotationalStiffnessX, rotationalStiffnessY, rotationalStiffnessZ)
        {
            WarpingStiffness = warpingStiffness;
        }

        public IfcWarpingStiffnessSelect WarpingStiffness { get; set; } // optional

        public new static IfcBoundaryNodeConditionWarping FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBoundaryNodeConditionWarping>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            TranslationalStiffnessX != null ? TranslationalStiffnessX.ToStepValue() : "$",
	            TranslationalStiffnessY != null ? TranslationalStiffnessY.ToStepValue() : "$",
	            TranslationalStiffnessZ != null ? TranslationalStiffnessZ.ToStepValue() : "$",
	            RotationalStiffnessX != null ? RotationalStiffnessX.ToStepValue() : "$",
	            RotationalStiffnessY != null ? RotationalStiffnessY.ToStepValue() : "$",
	            RotationalStiffnessZ != null ? RotationalStiffnessZ.ToStepValue() : "$",
	            WarpingStiffness != null ? WarpingStiffness.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}