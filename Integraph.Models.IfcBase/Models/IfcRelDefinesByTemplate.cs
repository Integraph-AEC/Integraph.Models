using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreldefinesbytemplate.htm" />
	/// </summary>
	public class IfcRelDefinesByTemplate : IfcRelDefines
    {
	    /// <summary>
	    ///     Construct a IfcRelDefinesByTemplate with all required attributes.
	    /// </summary>
	    public IfcRelDefinesByTemplate(IfcGloballyUniqueId globalId, List<IfcPropertySetDefinition> relatedPropertySets,
            IfcPropertySetTemplate relatingTemplate) : base(globalId)
        {
            RelatedPropertySets = relatedPropertySets;
            RelatingTemplate = relatingTemplate;
        }

	    /// <summary>
	    ///     Construct a IfcRelDefinesByTemplate with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelDefinesByTemplate(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcPropertySetDefinition> relatedPropertySets,
            IfcPropertySetTemplate relatingTemplate) : base(globalId, ownerHistory, name, description)
        {
            RelatedPropertySets = relatedPropertySets;
            RelatingTemplate = relatingTemplate;
        }

        public List<IfcPropertySetDefinition> RelatedPropertySets { get; set; }
        public IfcPropertySetTemplate RelatingTemplate { get; set; }

        public new static IfcRelDefinesByTemplate FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelDefinesByTemplate>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatedPropertySets != null ? RelatedPropertySets.ToStepValue() : "$",
                RelatingTemplate != null ? RelatingTemplate.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}