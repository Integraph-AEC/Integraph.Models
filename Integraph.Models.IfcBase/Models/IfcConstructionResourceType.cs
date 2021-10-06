using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconstructionresourcetype.htm" />
	/// </summary>
	public abstract class IfcConstructionResourceType : IfcTypeResource
    {
	    /// <summary>
	    ///     Construct a IfcConstructionResourceType with all required attributes.
	    /// </summary>
	    public IfcConstructionResourceType(IfcGloballyUniqueId globalId) : base(globalId)
        {
            BaseCosts = new List<IfcAppliedValue>();
        }

	    /// <summary>
	    ///     Construct a IfcConstructionResourceType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConstructionResourceType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            IfcIdentifier identification, IfcText longDescription, IfcLabel resourceType,
            List<IfcAppliedValue> baseCosts, IfcPhysicalQuantity baseQuantity) : base(globalId, ownerHistory, name,
            description, applicableOccurrence, hasPropertySets, identification, longDescription, resourceType)
        {
            BaseCosts = baseCosts;
            BaseQuantity = baseQuantity;
        }

        public List<IfcAppliedValue> BaseCosts { get; set; } // optional
        public IfcPhysicalQuantity BaseQuantity { get; set; } // optional

        public new static IfcConstructionResourceType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConstructionResourceType>(json);
        }
    }
}