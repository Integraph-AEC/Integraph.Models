using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcwallstandardcase.htm" />
	/// </summary>
	public class IfcWallStandardCase : IfcWall
    {
	    /// <summary>
	    ///     Construct a IfcWallStandardCase with all required attributes.
	    /// </summary>
	    public IfcWallStandardCase(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcWallStandardCase with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcWallStandardCase(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcWallTypeEnum predefinedType) : base(globalId,
            ownerHistory, name, description, objectType, objectPlacement, representation, tag, predefinedType)
        {
        }

        public new static IfcWallStandardCase FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcWallStandardCase>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ObjectType != null ? ObjectType.ToStepValue() : "$",
	            ObjectPlacement != null ? ObjectPlacement.ToStepValue() : "$",
	            Representation != null ? Representation.ToStepValue() : "$",
	            Tag != null ? Tag.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}