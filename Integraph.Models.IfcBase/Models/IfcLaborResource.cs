using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclaborresource.htm" />
	/// </summary>
	public class IfcLaborResource : IfcConstructionResource
    {
	    /// <summary>
	    ///     Construct a IfcLaborResource with all required attributes.
	    /// </summary>
	    public IfcLaborResource(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcLaborResource with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLaborResource(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcIdentifier identification, IfcText longDescription,
            IfcResourceTime usage, List<IfcAppliedValue> baseCosts, IfcPhysicalQuantity baseQuantity,
            IfcLaborResourceTypeEnum predefinedType) : base(globalId, ownerHistory, name, description, objectType,
            identification, longDescription, usage, baseCosts, baseQuantity)
        {
            PredefinedType = predefinedType;
        }

        public IfcLaborResourceTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcLaborResource FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLaborResource>(json);
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