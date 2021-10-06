using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreldefinesbytype.htm" />
	/// </summary>
	public class IfcRelDefinesByType : IfcRelDefines
    {
	    /// <summary>
	    ///     Construct a IfcRelDefinesByType with all required attributes.
	    /// </summary>
	    public IfcRelDefinesByType(IfcGloballyUniqueId globalId, List<IfcObject> relatedObjects,
            IfcTypeObject relatingType) : base(globalId)
        {
            RelatedObjects = relatedObjects;
            RelatingType = relatingType;
        }

	    /// <summary>
	    ///     Construct a IfcRelDefinesByType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelDefinesByType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcObject> relatedObjects, IfcTypeObject relatingType) : base(globalId,
            ownerHistory, name, description)
        {
            RelatedObjects = relatedObjects;
            RelatingType = relatingType;
        }

        public List<IfcObject> RelatedObjects { get; set; }
        public IfcTypeObject RelatingType { get; set; }

        public new static IfcRelDefinesByType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelDefinesByType>(json);
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
                RelatingType != null ? RelatingType.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}