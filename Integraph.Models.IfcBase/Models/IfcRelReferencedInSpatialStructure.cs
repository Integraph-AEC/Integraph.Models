using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelreferencedinspatialstructure.htm" />
	/// </summary>
	public class IfcRelReferencedInSpatialStructure : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelReferencedInSpatialStructure with all required attributes.
	    /// </summary>
	    public IfcRelReferencedInSpatialStructure(IfcGloballyUniqueId globalId, List<IfcProduct> relatedElements,
            IfcSpatialElement relatingStructure) : base(globalId)
        {
            RelatedElements = relatedElements;
            RelatingStructure = relatingStructure;
        }

	    /// <summary>
	    ///     Construct a IfcRelReferencedInSpatialStructure with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelReferencedInSpatialStructure(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory,
            IfcLabel name, IfcText description, List<IfcProduct> relatedElements, IfcSpatialElement relatingStructure) :
            base(globalId, ownerHistory, name, description)
        {
            RelatedElements = relatedElements;
            RelatingStructure = relatingStructure;
        }

        public List<IfcProduct> RelatedElements { get; set; }
        public IfcSpatialElement RelatingStructure { get; set; }

        public new static IfcRelReferencedInSpatialStructure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelReferencedInSpatialStructure>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatedElements != null ? RelatedElements.ToStepValue() : "$",
                RelatingStructure != null ? RelatingStructure.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}