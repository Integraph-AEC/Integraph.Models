using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcprocedure.htm" />
	/// </summary>
	public class IfcProcedure : IfcProcess
    {
	    /// <summary>
	    ///     Construct a IfcProcedure with all required attributes.
	    /// </summary>
	    public IfcProcedure(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcProcedure with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcProcedure(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcIdentifier identification, IfcText longDescription,
            IfcProcedureTypeEnum predefinedType) : base(globalId, ownerHistory, name, description, objectType,
            identification, longDescription)
        {
            PredefinedType = predefinedType;
        }

        public IfcProcedureTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcProcedure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcProcedure>(json);
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
	            LongDescription != null ? LongDescription.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}