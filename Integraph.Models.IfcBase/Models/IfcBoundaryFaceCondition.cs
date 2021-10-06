using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboundaryfacecondition.htm" />
	/// </summary>
	public class IfcBoundaryFaceCondition : IfcBoundaryCondition
    {
	    /// <summary>
	    ///     Construct a IfcBoundaryFaceCondition with all required attributes.
	    /// </summary>
	    public IfcBoundaryFaceCondition()
        {
        }

	    /// <summary>
	    ///     Construct a IfcBoundaryFaceCondition with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBoundaryFaceCondition(IfcLabel name, IfcModulusOfSubgradeReactionSelect translationalStiffnessByAreaX,
            IfcModulusOfSubgradeReactionSelect translationalStiffnessByAreaY,
            IfcModulusOfSubgradeReactionSelect translationalStiffnessByAreaZ) : base(name)
        {
            TranslationalStiffnessByAreaX = translationalStiffnessByAreaX;
            TranslationalStiffnessByAreaY = translationalStiffnessByAreaY;
            TranslationalStiffnessByAreaZ = translationalStiffnessByAreaZ;
        }

        public IfcModulusOfSubgradeReactionSelect TranslationalStiffnessByAreaX { get; set; } // optional
        public IfcModulusOfSubgradeReactionSelect TranslationalStiffnessByAreaY { get; set; } // optional
        public IfcModulusOfSubgradeReactionSelect TranslationalStiffnessByAreaZ { get; set; } // optional

        public new static IfcBoundaryFaceCondition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBoundaryFaceCondition>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            TranslationalStiffnessByAreaX != null ? TranslationalStiffnessByAreaX.ToStepValue() : "$",
	            TranslationalStiffnessByAreaY != null ? TranslationalStiffnessByAreaY.ToStepValue() : "$",
	            TranslationalStiffnessByAreaZ != null ? TranslationalStiffnessByAreaZ.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}