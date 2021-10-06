using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifceventtype.htm" />
	/// </summary>
	public class IfcEventType : IfcTypeProcess
    {
	    /// <summary>
	    ///     Construct a IfcEventType with all required attributes.
	    /// </summary>
	    public IfcEventType(IfcGloballyUniqueId globalId, IfcEventTypeEnum predefinedType,
            IfcEventTriggerTypeEnum eventTriggerType) : base(globalId)
        {
            PredefinedType = predefinedType;
            EventTriggerType = eventTriggerType;
        }

	    /// <summary>
	    ///     Construct a IfcEventType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcEventType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            IfcIdentifier identification, IfcText longDescription, IfcLabel processType,
            IfcEventTypeEnum predefinedType, IfcEventTriggerTypeEnum eventTriggerType,
            IfcLabel userDefinedEventTriggerType) : base(globalId, ownerHistory, name, description,
            applicableOccurrence, hasPropertySets, identification, longDescription, processType)
        {
            PredefinedType = predefinedType;
            EventTriggerType = eventTriggerType;
            UserDefinedEventTriggerType = userDefinedEventTriggerType;
        }

        public IfcEventTypeEnum? PredefinedType { get; set; }
        public IfcEventTriggerTypeEnum? EventTriggerType { get; set; }
        public IfcLabel UserDefinedEventTriggerType { get; set; } // optional

        public new static IfcEventType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcEventType>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                ApplicableOccurrence != null ? ApplicableOccurrence.ToStepValue() : "$",
                HasPropertySets != null ? HasPropertySets.ToStepValue() : "$",
                Identification != null ? Identification.ToStepValue() : "$",
                LongDescription != null ? LongDescription.ToStepValue() : "$",
                ProcessType != null ? ProcessType.ToStepValue() : "$",
                PredefinedType.ToStepValue(),
                EventTriggerType.ToStepValue(),
                UserDefinedEventTriggerType != null ? UserDefinedEventTriggerType.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}