using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccrewresource.htm" />
	/// </summary>
	public class IfcCrewResource : IfcConstructionResource
    {
	    /// <summary>
	    ///     Construct a IfcCrewResource with all required attributes.
	    /// </summary>
	    public IfcCrewResource(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcCrewResource with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCrewResource(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcIdentifier identification, IfcText longDescription,
            IfcResourceTime usage, List<IfcAppliedValue> baseCosts, IfcPhysicalQuantity baseQuantity,
            IfcCrewResourceTypeEnum predefinedType) : base(globalId, ownerHistory, name, description, objectType,
            identification, longDescription, usage, baseCosts, baseQuantity)
        {
            PredefinedType = predefinedType;
        }

        public IfcCrewResourceTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcCrewResource FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCrewResource>(json);
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
	            Usage != null ? Usage.ToStepValue() : "$",
	            BaseCosts != null ? BaseCosts.ToStepValue() : "$",
	            BaseQuantity != null ? BaseQuantity.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}