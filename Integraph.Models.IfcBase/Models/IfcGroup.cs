using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcgroup.htm" />
	/// </summary>
	public class IfcGroup : IfcObject
    {
	    /// <summary>
	    ///     Construct a IfcGroup with all required attributes.
	    /// </summary>
	    public IfcGroup(IfcGloballyUniqueId globalId) : base(globalId)
        {
            IsGroupedBy = new List<IfcRelAssignsToGroup>();
        }

	    /// <summary>
	    ///     Construct a IfcGroup with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcGroup(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType) : base(globalId, ownerHistory, name, description, objectType)
        {
            IsGroupedBy = new List<IfcRelAssignsToGroup>();
        }

        public List<IfcRelAssignsToGroup> IsGroupedBy { get; set; } // inverse

        public new static IfcGroup FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcGroup>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ObjectType != null ? ObjectType.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}