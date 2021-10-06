using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelassociateslibrary.htm" />
	/// </summary>
	public class IfcRelAssociatesLibrary : IfcRelAssociates
    {
	    /// <summary>
	    ///     Construct a IfcRelAssociatesLibrary with all required attributes.
	    /// </summary>
	    public IfcRelAssociatesLibrary(IfcGloballyUniqueId globalId, List<IfcDefinitionSelect> relatedObjects,
            IfcLibrarySelect relatingLibrary) : base(globalId, relatedObjects)
        {
            RelatingLibrary = relatingLibrary;
        }

	    /// <summary>
	    ///     Construct a IfcRelAssociatesLibrary with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelAssociatesLibrary(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcDefinitionSelect> relatedObjects, IfcLibrarySelect relatingLibrary) : base(
            globalId, ownerHistory, name, description, relatedObjects)
        {
            RelatingLibrary = relatingLibrary;
        }

        public IfcLibrarySelect RelatingLibrary { get; set; }

        public new static IfcRelAssociatesLibrary FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelAssociatesLibrary>(json);
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
                RelatingLibrary != null ? RelatingLibrary.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}