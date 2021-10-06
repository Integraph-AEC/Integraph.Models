using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpermit.htm" />
	/// </summary>
	public class IfcPermit : IfcControl
    {
	    /// <summary>
	    ///     Construct a IfcPermit with all required attributes.
	    /// </summary>
	    public IfcPermit(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcPermit with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPermit(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcIdentifier identification, IfcPermitTypeEnum predefinedType, IfcLabel status,
            IfcText longDescription) : base(globalId, ownerHistory, name, description, objectType, identification)
        {
            PredefinedType = predefinedType;
            Status = status;
            LongDescription = longDescription;
        }

        public IfcPermitTypeEnum? PredefinedType { get; set; } // optional
        public IfcLabel Status { get; set; } // optional
        public IfcText LongDescription { get; set; } // optional

        public new static IfcPermit FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPermit>(json);
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
	            Identification != null ? Identification.ToStepValue() : "$",
	            PredefinedType.ToStepValue(),
	            Status != null ? Status.ToStepValue() : "$",
	            LongDescription != null ? LongDescription.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}