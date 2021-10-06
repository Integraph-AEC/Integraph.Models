using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcslabelementedcase.htm" />
	/// </summary>
	public class IfcSlabElementedCase : IfcSlab
    {
	    /// <summary>
	    ///     Construct a IfcSlabElementedCase with all required attributes.
	    /// </summary>
	    public IfcSlabElementedCase(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcSlabElementedCase with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSlabElementedCase(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcSlabTypeEnum predefinedType) : base(globalId,
            ownerHistory, name, description, objectType, objectPlacement, representation, tag, predefinedType)
        {
        }

        public new static IfcSlabElementedCase FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSlabElementedCase>(json);
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