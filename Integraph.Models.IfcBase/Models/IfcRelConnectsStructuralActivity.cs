using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelconnectsstructuralactivity.htm" />
	/// </summary>
	public class IfcRelConnectsStructuralActivity : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelConnectsStructuralActivity with all required attributes.
	    /// </summary>
	    public IfcRelConnectsStructuralActivity(IfcGloballyUniqueId globalId,
            IfcStructuralActivityAssignmentSelect relatingElement,
            IfcStructuralActivity relatedStructuralActivity) : base(globalId)
        {
            RelatingElement = relatingElement;
            RelatedStructuralActivity = relatedStructuralActivity;
        }

	    /// <summary>
	    ///     Construct a IfcRelConnectsStructuralActivity with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelConnectsStructuralActivity(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory,
            IfcLabel name, IfcText description, IfcStructuralActivityAssignmentSelect relatingElement,
            IfcStructuralActivity relatedStructuralActivity) : base(globalId, ownerHistory, name, description)
        {
            RelatingElement = relatingElement;
            RelatedStructuralActivity = relatedStructuralActivity;
        }

        public IfcStructuralActivityAssignmentSelect RelatingElement { get; set; }
        public IfcStructuralActivity RelatedStructuralActivity { get; set; }

        public new static IfcRelConnectsStructuralActivity FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelConnectsStructuralActivity>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingElement != null ? RelatingElement.ToStepValue() : "$",
                RelatedStructuralActivity != null ? RelatedStructuralActivity.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}