using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctasktype.htm" />
	/// </summary>
	public class IfcTaskType : IfcTypeProcess
    {
	    /// <summary>
	    ///     Construct a IfcTaskType with all required attributes.
	    /// </summary>
	    public IfcTaskType(IfcGloballyUniqueId globalId, IfcTaskTypeEnum predefinedType) : base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcTaskType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTaskType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            IfcIdentifier identification, IfcText longDescription, IfcLabel processType, IfcTaskTypeEnum predefinedType,
            IfcLabel workMethod) : base(globalId, ownerHistory, name, description, applicableOccurrence,
            hasPropertySets, identification, longDescription, processType)
        {
            PredefinedType = predefinedType;
            WorkMethod = workMethod;
        }

        public IfcTaskTypeEnum? PredefinedType { get; set; }
        public IfcLabel WorkMethod { get; set; } // optional

        public new static IfcTaskType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTaskType>(json);
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
	            WorkMethod != null ? WorkMethod.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}