using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbeamstandardcase.htm" />
	/// </summary>
	public class IfcBeamStandardCase : IfcBeam
    {
	    /// <summary>
	    ///     Construct a IfcBeamStandardCase with all required attributes.
	    /// </summary>
	    public IfcBeamStandardCase(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcBeamStandardCase with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBeamStandardCase(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcBeamTypeEnum predefinedType) : base(globalId,
            ownerHistory, name, description, objectType, objectPlacement, representation, tag, predefinedType)
        {
        }

        public new static IfcBeamStandardCase FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBeamStandardCase>(json);
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