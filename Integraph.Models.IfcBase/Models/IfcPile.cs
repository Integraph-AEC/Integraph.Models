using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpile.htm" />
	/// </summary>
	public class IfcPile : IfcBuildingElement
    {
	    /// <summary>
	    ///     Construct a IfcPile with all required attributes.
	    /// </summary>
	    public IfcPile(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcPile with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPile(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcObjectPlacement objectPlacement, IfcProductRepresentation representation,
            IfcIdentifier tag, IfcPileTypeEnum predefinedType, IfcPileConstructionEnum constructionType) : base(
            globalId, ownerHistory, name, description, objectType, objectPlacement, representation, tag)
        {
            PredefinedType = predefinedType;
            ConstructionType = constructionType;
        }

        public IfcPileTypeEnum? PredefinedType { get; set; } // optional
        public IfcPileConstructionEnum? ConstructionType { get; set; } // optional

        public new static IfcPile FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPile>(json);
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
	            PredefinedType.ToStepValue(),
	            ConstructionType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}