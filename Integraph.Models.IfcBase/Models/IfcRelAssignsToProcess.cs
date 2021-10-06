using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassignstoprocess.htm" />
	/// </summary>
	public class IfcRelAssignsToProcess : IfcRelAssigns
    {
	    /// <summary>
	    ///     Construct a IfcRelAssignsToProcess with all required attributes.
	    /// </summary>
	    public IfcRelAssignsToProcess(IfcGloballyUniqueId globalId, List<IfcObjectDefinition> relatedObjects,
            IfcProcessSelect relatingProcess) : base(globalId, relatedObjects)
        {
            RelatingProcess = relatingProcess;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssignsToProcess with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssignsToProcess(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcObjectDefinition> relatedObjects, IfcObjectTypeEnum relatedObjectsType,
            IfcProcessSelect relatingProcess, IfcMeasureWithUnit quantityInProcess) : base(globalId, ownerHistory, name,
            description, relatedObjects, relatedObjectsType)
        {
            RelatingProcess = relatingProcess;
            QuantityInProcess = quantityInProcess;
        }

        public IfcProcessSelect RelatingProcess { get; set; }
        public IfcMeasureWithUnit QuantityInProcess { get; set; } // optional

        public new static IfcRelAssignsToProcess FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssignsToProcess>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatedObjects != null ? RelatedObjects.ToStepValue() : "$",
                RelatedObjectsType.ToStepValue(),
                RelatingProcess != null ? RelatingProcess.ToStepValue() : "$",
                QuantityInProcess != null ? QuantityInProcess.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}