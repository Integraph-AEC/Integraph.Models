using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboundarynodecondition.htm" />
	/// </summary>
	public class IfcBoundaryNodeCondition : IfcBoundaryCondition
    {
	    /// <summary>
	    ///     Construct a IfcBoundaryNodeCondition with all required attributes.
	    /// </summary>
	    public IfcBoundaryNodeCondition()
        {
        }

	    /// <summary>
	    ///     Construct a IfcBoundaryNodeCondition with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBoundaryNodeCondition(IfcLabel name, IfcTranslationalStiffnessSelect translationalStiffnessX,
            IfcTranslationalStiffnessSelect translationalStiffnessY,
            IfcTranslationalStiffnessSelect translationalStiffnessZ, IfcRotationalStiffnessSelect rotationalStiffnessX,
            IfcRotationalStiffnessSelect rotationalStiffnessY,
            IfcRotationalStiffnessSelect rotationalStiffnessZ) : base(name)
        {
            TranslationalStiffnessX = translationalStiffnessX;
            TranslationalStiffnessY = translationalStiffnessY;
            TranslationalStiffnessZ = translationalStiffnessZ;
            RotationalStiffnessX = rotationalStiffnessX;
            RotationalStiffnessY = rotationalStiffnessY;
            RotationalStiffnessZ = rotationalStiffnessZ;
        }

        public IfcTranslationalStiffnessSelect TranslationalStiffnessX { get; set; } // optional
        public IfcTranslationalStiffnessSelect TranslationalStiffnessY { get; set; } // optional
        public IfcTranslationalStiffnessSelect TranslationalStiffnessZ { get; set; } // optional
        public IfcRotationalStiffnessSelect RotationalStiffnessX { get; set; } // optional
        public IfcRotationalStiffnessSelect RotationalStiffnessY { get; set; } // optional
        public IfcRotationalStiffnessSelect RotationalStiffnessZ { get; set; } // optional

        public new static IfcBoundaryNodeCondition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBoundaryNodeCondition>(json);
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
	            RotationalStiffnessZ != null ? RotationalStiffnessZ.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}