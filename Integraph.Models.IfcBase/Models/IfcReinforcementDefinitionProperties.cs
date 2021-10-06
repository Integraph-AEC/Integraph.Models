using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreinforcementdefinitionproperties.htm" />
	/// </summary>
	public class IfcReinforcementDefinitionProperties : IfcPreDefinedPropertySet
    {
	    /// <summary>
	    ///     Construct a IfcReinforcementDefinitionProperties with all required attributes.
	    /// </summary>
	    public IfcReinforcementDefinitionProperties(IfcGloballyUniqueId globalId,
            List<IfcSectionReinforcementProperties> reinforcementSectionDefinitions) : base(globalId)
        {
            ReinforcementSectionDefinitions = reinforcementSectionDefinitions;
        }

	    /// <summary>
	    ///     Construct a IfcReinforcementDefinitionProperties with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcReinforcementDefinitionProperties(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory,
            IfcLabel name, IfcText description, IfcLabel definitionType,
            List<IfcSectionReinforcementProperties> reinforcementSectionDefinitions) : base(globalId, ownerHistory,
            name, description)
        {
            DefinitionType = definitionType;
            ReinforcementSectionDefinitions = reinforcementSectionDefinitions;
        }

        public IfcLabel DefinitionType { get; set; } // optional
        public List<IfcSectionReinforcementProperties> ReinforcementSectionDefinitions { get; set; }

        public new static IfcReinforcementDefinitionProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcReinforcementDefinitionProperties>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                DefinitionType != null ? DefinitionType.ToStepValue() : "$",
                ReinforcementSectionDefinitions != null ? ReinforcementSectionDefinitions.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}