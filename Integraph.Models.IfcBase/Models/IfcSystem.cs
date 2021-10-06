using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsystem.htm" />
	/// </summary>
	public class IfcSystem : IfcGroup
    {
	    /// <summary>
	    ///     Construct a IfcSystem with all required attributes.
	    /// </summary>
	    public IfcSystem(IfcGloballyUniqueId globalId) : base(globalId)
        {
            ServicesBuildings = new List<IfcRelServicesBuildings>();
        }

	    /// <summary>
	    ///     Construct a IfcSystem with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSystem(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType) : base(globalId, ownerHistory, name, description, objectType)
        {
            ServicesBuildings = new List<IfcRelServicesBuildings>();
        }

        public List<IfcRelServicesBuildings> ServicesBuildings { get; set; } // inverse

        public new static IfcSystem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSystem>(json);
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