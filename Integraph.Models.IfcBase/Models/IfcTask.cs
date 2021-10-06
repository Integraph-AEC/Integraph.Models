using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctask.htm" />
	/// </summary>
	public class IfcTask : IfcProcess
    {
	    /// <summary>
	    ///     Construct a IfcTask with all required attributes.
	    /// </summary>
	    public IfcTask(IfcGloballyUniqueId globalId, IfcBoolean isMilestone) : base(globalId)
        {
            IsMilestone = isMilestone;
        }

	    /// <summary>
	    ///     Construct a IfcTask with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTask(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcIdentifier identification, IfcText longDescription, IfcLabel status,
            IfcLabel workMethod, IfcBoolean isMilestone, IfcInteger priority, IfcTaskTime taskTime,
            IfcTaskTypeEnum predefinedType) : base(globalId, ownerHistory, name, description, objectType,
            identification, longDescription)
        {
            Status = status;
            WorkMethod = workMethod;
            IsMilestone = isMilestone;
            Priority = priority;
            TaskTime = taskTime;
            PredefinedType = predefinedType;
        }

        public IfcLabel Status { get; set; } // optional
        public IfcLabel WorkMethod { get; set; } // optional
        public IfcBoolean IsMilestone { get; set; }
        public IfcInteger Priority { get; set; } // optional
        public IfcTaskTime TaskTime { get; set; } // optional
        public IfcTaskTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcTask FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTask>(json);
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
	            Status != null ? Status.ToStepValue() : "$",
	            WorkMethod != null ? WorkMethod.ToStepValue() : "$",
	            IsMilestone != null ? IsMilestone.ToStepValue() : "$",
	            Priority != null ? Priority.ToStepValue() : "$",
	            TaskTime != null ? TaskTime.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}