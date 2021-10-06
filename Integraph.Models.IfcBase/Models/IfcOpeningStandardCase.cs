using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcopeningstandardcase.htm" />
	/// </summary>
	public class IfcOpeningStandardCase : IfcOpeningElement
    {
	    /// <summary>
	    ///     Construct a IfcOpeningStandardCase with all required attributes.
	    /// </summary>
	    public IfcOpeningStandardCase(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcOpeningStandardCase with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcOpeningStandardCase(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcOpeningElementTypeEnum predefinedType) :
            base(globalId, ownerHistory, name, description, objectType, objectPlacement, representation, tag,
                predefinedType)
        {
        }

        public new static IfcOpeningStandardCase FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcOpeningStandardCase>(json);
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