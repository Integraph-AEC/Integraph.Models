using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsectionreinforcementproperties.htm" />
	/// </summary>
	public class IfcSectionReinforcementProperties : IfcPreDefinedProperties
    {
	    /// <summary>
	    ///     Construct a IfcSectionReinforcementProperties with all required attributes.
	    /// </summary>
	    public IfcSectionReinforcementProperties(IfcLengthMeasure longitudinalStartPosition,
            IfcLengthMeasure longitudinalEndPosition, IfcReinforcingBarRoleEnum reinforcementRole,
            IfcSectionProperties sectionDefinition,
            List<IfcReinforcementBarProperties> crossSectionReinforcementDefinitions)
        {
            LongitudinalStartPosition = longitudinalStartPosition;
            LongitudinalEndPosition = longitudinalEndPosition;
            ReinforcementRole = reinforcementRole;
            SectionDefinition = sectionDefinition;
            CrossSectionReinforcementDefinitions = crossSectionReinforcementDefinitions;
        }

	    /// <summary>
	    ///     Construct a IfcSectionReinforcementProperties with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSectionReinforcementProperties(IfcLengthMeasure longitudinalStartPosition,
            IfcLengthMeasure longitudinalEndPosition, IfcLengthMeasure transversePosition,
            IfcReinforcingBarRoleEnum reinforcementRole, IfcSectionProperties sectionDefinition,
            List<IfcReinforcementBarProperties> crossSectionReinforcementDefinitions)
        {
            LongitudinalStartPosition = longitudinalStartPosition;
            LongitudinalEndPosition = longitudinalEndPosition;
            TransversePosition = transversePosition;
            ReinforcementRole = reinforcementRole;
            SectionDefinition = sectionDefinition;
            CrossSectionReinforcementDefinitions = crossSectionReinforcementDefinitions;
        }

        public IfcLengthMeasure LongitudinalStartPosition { get; set; }
        public IfcLengthMeasure LongitudinalEndPosition { get; set; }
        public IfcLengthMeasure TransversePosition { get; set; } // optional
        public IfcReinforcingBarRoleEnum? ReinforcementRole { get; set; }
        public IfcSectionProperties SectionDefinition { get; set; }
        public List<IfcReinforcementBarProperties> CrossSectionReinforcementDefinitions { get; set; }

        public new static IfcSectionReinforcementProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSectionReinforcementProperties>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                LongitudinalStartPosition != null ? LongitudinalStartPosition.ToStepValue() : "$",
                LongitudinalEndPosition != null ? LongitudinalEndPosition.ToStepValue() : "$",
                TransversePosition != null ? TransversePosition.ToStepValue() : "$",
                ReinforcementRole.ToStepValue(),
                SectionDefinition != null ? SectionDefinition.ToStepValue() : "$",
                CrossSectionReinforcementDefinitions != null
                    ? CrossSectionReinforcementDefinitions.ToStepValue()
                    : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}