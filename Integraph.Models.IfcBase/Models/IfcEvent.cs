using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcevent.htm" />
	/// </summary>
	public class IfcEvent : IfcProcess
    {
	    /// <summary>
	    ///     Construct a IfcEvent with all required attributes.
	    /// </summary>
	    public IfcEvent(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcEvent with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcEvent(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcIdentifier identification, IfcText longDescription, IfcEventTypeEnum predefinedType,
            IfcEventTriggerTypeEnum eventTriggerType, IfcLabel userDefinedEventTriggerType,
            IfcEventTime eventOccurenceTime) : base(globalId, ownerHistory, name, description, objectType,
            identification, longDescription)
        {
            PredefinedType = predefinedType;
            EventTriggerType = eventTriggerType;
            UserDefinedEventTriggerType = userDefinedEventTriggerType;
            EventOccurenceTime = eventOccurenceTime;
        }

        public IfcEventTypeEnum? PredefinedType { get; set; } // optional
        public IfcEventTriggerTypeEnum? EventTriggerType { get; set; } // optional
        public IfcLabel UserDefinedEventTriggerType { get; set; } // optional
        public IfcEventTime EventOccurenceTime { get; set; } // optional

        public new static IfcEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcEvent>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ObjectType != null ? ObjectType.ToStepValue() : "$",
	            Identification != null ? Identification.ToStepValue() : "$",
	            LongDescription != null ? LongDescription.ToStepValue() : "$",
	            PredefinedType.ToStepValue(),
	            EventTriggerType.ToStepValue(),
	            UserDefinedEventTriggerType != null ? UserDefinedEventTriggerType.ToStepValue() : "$",
	            EventOccurenceTime != null ? EventOccurenceTime.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}