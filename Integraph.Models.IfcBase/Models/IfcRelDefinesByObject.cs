using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreldefinesbyobject.htm" />
	/// </summary>
	public class IfcRelDefinesByObject : IfcRelDefines
    {
	    /// <summary>
	    ///     Construct a IfcRelDefinesByObject with all required attributes.
	    /// </summary>
	    public IfcRelDefinesByObject(IfcGloballyUniqueId globalId, List<IfcObject> relatedObjects,
            IfcObject relatingObject) : base(globalId)
        {
            RelatedObjects = relatedObjects;
            RelatingObject = relatingObject;
        }

	    /// <summary>
	    ///     Construct a IfcRelDefinesByObject with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelDefinesByObject(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcObject> relatedObjects, IfcObject relatingObject) : base(globalId,
            ownerHistory, name, description)
        {
            RelatedObjects = relatedObjects;
            RelatingObject = relatingObject;
        }

        public List<IfcObject> RelatedObjects { get; set; }
        public IfcObject RelatingObject { get; set; }

        public new static IfcRelDefinesByObject FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelDefinesByObject>(json);
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
                RelatingObject != null ? RelatingObject.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}