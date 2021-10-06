using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelcoversbldgelements.htm" />
	/// </summary>
	public class IfcRelCoversBldgElements : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelCoversBldgElements with all required attributes.
	    /// </summary>
	    public IfcRelCoversBldgElements(IfcGloballyUniqueId globalId, IfcElement relatingBuildingElement,
            List<IfcCovering> relatedCoverings) : base(globalId)
        {
            RelatingBuildingElement = relatingBuildingElement;
            RelatedCoverings = relatedCoverings;
        }

	    /// <summary>
	    ///     Construct a IfcRelCoversBldgElements with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelCoversBldgElements(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcElement relatingBuildingElement, List<IfcCovering> relatedCoverings) : base(
            globalId, ownerHistory, name, description)
        {
            RelatingBuildingElement = relatingBuildingElement;
            RelatedCoverings = relatedCoverings;
        }

        public IfcElement RelatingBuildingElement { get; set; }
        public List<IfcCovering> RelatedCoverings { get; set; }

        public new static IfcRelCoversBldgElements FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelCoversBldgElements>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingBuildingElement != null ? RelatingBuildingElement.ToStepValue() : "$",
                RelatedCoverings != null ? RelatedCoverings.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}