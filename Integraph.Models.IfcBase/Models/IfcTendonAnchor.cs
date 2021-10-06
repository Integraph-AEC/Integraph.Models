using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctendonanchor.htm" />
	/// </summary>
	public class IfcTendonAnchor : IfcReinforcingElement
    {
	    /// <summary>
	    ///     Construct a IfcTendonAnchor with all required attributes.
	    /// </summary>
	    public IfcTendonAnchor(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcTendonAnchor with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTendonAnchor(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcLabel steelGrade,
            IfcTendonAnchorTypeEnum predefinedType) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation, tag, steelGrade)
        {
            PredefinedType = predefinedType;
        }

        public IfcTendonAnchorTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcTendonAnchor FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTendonAnchor>(json);
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
	            SteelGrade != null ? SteelGrade.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}