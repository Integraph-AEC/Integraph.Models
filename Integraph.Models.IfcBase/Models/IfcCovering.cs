using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccovering.htm" />
	/// </summary>
	public class IfcCovering : IfcBuildingElement
    {
	    /// <summary>
	    ///     Construct a IfcCovering with all required attributes.
	    /// </summary>
	    public IfcCovering(IfcGloballyUniqueId globalId) : base(globalId)
        {
            CoversSpaces = new List<IfcRelCoversSpaces>();
            CoversElements = new List<IfcRelCoversBldgElements>();
        }

	    /// <summary>
	    ///     Construct a IfcCovering with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCovering(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcCoveringTypeEnum predefinedType) : base(
            globalId, ownerHistory, name, description, objectType, objectPlacement, representation, tag)
        {
            CoversSpaces = new List<IfcRelCoversSpaces>();
            CoversElements = new List<IfcRelCoversBldgElements>();

            PredefinedType = predefinedType;
        }

        public IfcCoveringTypeEnum? PredefinedType { get; set; } // optional
        public List<IfcRelCoversSpaces> CoversSpaces { get; set; } // inverse
        public List<IfcRelCoversBldgElements> CoversElements { get; set; } // inverse

        public new static IfcCovering FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCovering>(json);
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