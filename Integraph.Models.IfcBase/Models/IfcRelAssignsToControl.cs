using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassignstocontrol.htm" />
	/// </summary>
	public class IfcRelAssignsToControl : IfcRelAssigns
    {
	    /// <summary>
	    ///     Construct a IfcRelAssignsToControl with all required attributes.
	    /// </summary>
	    public IfcRelAssignsToControl(IfcGloballyUniqueId globalId, List<IfcObjectDefinition> relatedObjects,
            IfcControl relatingControl) : base(globalId, relatedObjects)
        {
            RelatingControl = relatingControl;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssignsToControl with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssignsToControl(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcObjectDefinition> relatedObjects, IfcObjectTypeEnum relatedObjectsType,
            IfcControl relatingControl) : base(globalId, ownerHistory, name, description, relatedObjects,
            relatedObjectsType)
        {
            RelatingControl = relatingControl;
        }

        public IfcControl RelatingControl { get; set; }

        public new static IfcRelAssignsToControl FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssignsToControl>(json);
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
                RelatingControl != null ? RelatingControl.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}