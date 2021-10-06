using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelcoversspaces.htm" />
	/// </summary>
	public class IfcRelCoversSpaces : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelCoversSpaces with all required attributes.
	    /// </summary>
	    public IfcRelCoversSpaces(IfcGloballyUniqueId globalId, IfcSpace relatingSpace,
            List<IfcCovering> relatedCoverings) : base(globalId)
        {
            RelatingSpace = relatingSpace;
            RelatedCoverings = relatedCoverings;
        }

	    /// <summary>
	    ///     Construct a IfcRelCoversSpaces with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelCoversSpaces(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcSpace relatingSpace, List<IfcCovering> relatedCoverings) : base(globalId,
            ownerHistory, name, description)
        {
            RelatingSpace = relatingSpace;
            RelatedCoverings = relatedCoverings;
        }

        public IfcSpace RelatingSpace { get; set; }
        public List<IfcCovering> RelatedCoverings { get; set; }

        public new static IfcRelCoversSpaces FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelCoversSpaces>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingSpace != null ? RelatingSpace.ToStepValue() : "$",
                RelatedCoverings != null ? RelatedCoverings.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}