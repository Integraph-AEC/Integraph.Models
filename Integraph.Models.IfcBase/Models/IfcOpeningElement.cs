using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcopeningelement.htm" />
	/// </summary>
	public class IfcOpeningElement : IfcFeatureElementSubtraction
    {
	    /// <summary>
	    ///     Construct a IfcOpeningElement with all required attributes.
	    /// </summary>
	    public IfcOpeningElement(IfcGloballyUniqueId globalId) : base(globalId)
        {
            HasFillings = new List<IfcRelFillsElement>();
        }

	    /// <summary>
	    ///     Construct a IfcOpeningElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcOpeningElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcOpeningElementTypeEnum predefinedType) :
            base(globalId, ownerHistory, name, description, objectType, objectPlacement, representation, tag)
        {
            HasFillings = new List<IfcRelFillsElement>();

            PredefinedType = predefinedType;
        }

        public IfcOpeningElementTypeEnum? PredefinedType { get; set; } // optional
        public List<IfcRelFillsElement> HasFillings { get; set; } // inverse

        public new static IfcOpeningElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcOpeningElement>(json);
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