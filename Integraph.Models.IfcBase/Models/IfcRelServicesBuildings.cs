using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelservicesbuildings.htm" />
	/// </summary>
	public class IfcRelServicesBuildings : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelServicesBuildings with all required attributes.
	    /// </summary>
	    public IfcRelServicesBuildings(IfcGloballyUniqueId globalId, IfcSystem relatingSystem,
            List<IfcSpatialElement> relatedBuildings) : base(globalId)
        {
            RelatingSystem = relatingSystem;
            RelatedBuildings = relatedBuildings;
        }

	    /// <summary>
	    ///     Construct a IfcRelServicesBuildings with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelServicesBuildings(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcSystem relatingSystem, List<IfcSpatialElement> relatedBuildings) : base(globalId,
            ownerHistory, name, description)
        {
            RelatingSystem = relatingSystem;
            RelatedBuildings = relatedBuildings;
        }

        public IfcSystem RelatingSystem { get; set; }
        public List<IfcSpatialElement> RelatedBuildings { get; set; }

        public new static IfcRelServicesBuildings FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelServicesBuildings>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingSystem != null ? RelatingSystem.ToStepValue() : "$",
                RelatedBuildings != null ? RelatedBuildings.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}