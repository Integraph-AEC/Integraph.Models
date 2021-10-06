using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcperformancehistory.htm" />
	/// </summary>
	public class IfcPerformanceHistory : IfcControl
    {
	    /// <summary>
	    ///     Construct a IfcPerformanceHistory with all required attributes.
	    /// </summary>
	    public IfcPerformanceHistory(IfcGloballyUniqueId globalId, IfcLabel lifeCyclePhase) : base(globalId)
        {
            LifeCyclePhase = lifeCyclePhase;
        }

	    /// <summary>
	    ///     Construct a IfcPerformanceHistory with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPerformanceHistory(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcIdentifier identification, IfcLabel lifeCyclePhase,
            IfcPerformanceHistoryTypeEnum predefinedType) : base(globalId, ownerHistory, name, description, objectType,
            identification)
        {
            LifeCyclePhase = lifeCyclePhase;
            PredefinedType = predefinedType;
        }

        public IfcLabel LifeCyclePhase { get; set; }
        public IfcPerformanceHistoryTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcPerformanceHistory FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPerformanceHistory>(json);
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
	            LifeCyclePhase != null ? LifeCyclePhase.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}