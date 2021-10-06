using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconstructionresource.htm" />
	/// </summary>
	public abstract class IfcConstructionResource : IfcResource
    {
	    /// <summary>
	    ///     Construct a IfcConstructionResource with all required attributes.
	    /// </summary>
	    public IfcConstructionResource(IfcGloballyUniqueId globalId) : base(globalId)
        {
            BaseCosts = new List<IfcAppliedValue>();
        }

	    /// <summary>
	    ///     Construct a IfcConstructionResource with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConstructionResource(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcIdentifier identification, IfcText longDescription,
            IfcResourceTime usage, List<IfcAppliedValue> baseCosts, IfcPhysicalQuantity baseQuantity) : base(globalId,
            ownerHistory, name, description, objectType, identification, longDescription)
        {
            Usage = usage;
            BaseCosts = baseCosts;
            BaseQuantity = baseQuantity;
        }

        public IfcResourceTime Usage { get; set; } // optional
        public List<IfcAppliedValue> BaseCosts { get; set; } // optional
        public IfcPhysicalQuantity BaseQuantity { get; set; } // optional

        public new static IfcConstructionResource FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConstructionResource>(json);
        }
    }
}