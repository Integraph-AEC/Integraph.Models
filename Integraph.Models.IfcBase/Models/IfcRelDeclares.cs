using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreldeclares.htm" />
	/// </summary>
	public class IfcRelDeclares : IfcRelationship
    {
	    /// <summary>
	    ///     Construct a IfcRelDeclares with all required attributes.
	    /// </summary>
	    public IfcRelDeclares(IfcGloballyUniqueId globalId, IfcContext relatingContext,
            List<IfcDefinitionSelect> relatedDefinitions) : base(globalId)
        {
            RelatingContext = relatingContext;
            RelatedDefinitions = relatedDefinitions;
        }

	    /// <summary>
	    ///     Construct a IfcRelDeclares with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelDeclares(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcContext relatingContext, List<IfcDefinitionSelect> relatedDefinitions) : base(
            globalId, ownerHistory, name, description)
        {
            RelatingContext = relatingContext;
            RelatedDefinitions = relatedDefinitions;
        }

        public IfcContext RelatingContext { get; set; }
        public List<IfcDefinitionSelect> RelatedDefinitions { get; set; }

        public new static IfcRelDeclares FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelDeclares>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingContext != null ? RelatingContext.ToStepValue() : "$",
                RelatedDefinitions != null ? RelatedDefinitions.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}