using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboundaryedgecondition.htm" />
	/// </summary>
	public class IfcBoundaryEdgeCondition : IfcBoundaryCondition
    {
	    /// <summary>
	    ///     Construct a IfcBoundaryEdgeCondition with all required attributes.
	    /// </summary>
	    public IfcBoundaryEdgeCondition()
        {
        }

	    /// <summary>
	    ///     Construct a IfcBoundaryEdgeCondition with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBoundaryEdgeCondition(IfcLabel name,
            IfcModulusOfTranslationalSubgradeReactionSelect translationalStiffnessByLengthX,
            IfcModulusOfTranslationalSubgradeReactionSelect translationalStiffnessByLengthY,
            IfcModulusOfTranslationalSubgradeReactionSelect translationalStiffnessByLengthZ,
            IfcModulusOfRotationalSubgradeReactionSelect rotationalStiffnessByLengthX,
            IfcModulusOfRotationalSubgradeReactionSelect rotationalStiffnessByLengthY,
            IfcModulusOfRotationalSubgradeReactionSelect rotationalStiffnessByLengthZ) : base(name)
        {
            TranslationalStiffnessByLengthX = translationalStiffnessByLengthX;
            TranslationalStiffnessByLengthY = translationalStiffnessByLengthY;
            TranslationalStiffnessByLengthZ = translationalStiffnessByLengthZ;
            RotationalStiffnessByLengthX = rotationalStiffnessByLengthX;
            RotationalStiffnessByLengthY = rotationalStiffnessByLengthY;
            RotationalStiffnessByLengthZ = rotationalStiffnessByLengthZ;
        }

        public IfcModulusOfTranslationalSubgradeReactionSelect TranslationalStiffnessByLengthX { get; set; } // optional
        public IfcModulusOfTranslationalSubgradeReactionSelect TranslationalStiffnessByLengthY { get; set; } // optional
        public IfcModulusOfTranslationalSubgradeReactionSelect TranslationalStiffnessByLengthZ { get; set; } // optional
        public IfcModulusOfRotationalSubgradeReactionSelect RotationalStiffnessByLengthX { get; set; } // optional
        public IfcModulusOfRotationalSubgradeReactionSelect RotationalStiffnessByLengthY { get; set; } // optional
        public IfcModulusOfRotationalSubgradeReactionSelect RotationalStiffnessByLengthZ { get; set; } // optional

        public new static IfcBoundaryEdgeCondition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBoundaryEdgeCondition>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                TranslationalStiffnessByLengthX != null ? TranslationalStiffnessByLengthX.ToStepValue() : "$",
                TranslationalStiffnessByLengthY != null ? TranslationalStiffnessByLengthY.ToStepValue() : "$",
                TranslationalStiffnessByLengthZ != null ? TranslationalStiffnessByLengthZ.ToStepValue() : "$",
                RotationalStiffnessByLengthX != null ? RotationalStiffnessByLengthX.ToStepValue() : "$",
                RotationalStiffnessByLengthY != null ? RotationalStiffnessByLengthY.ToStepValue() : "$",
                RotationalStiffnessByLengthZ != null ? RotationalStiffnessByLengthZ.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}