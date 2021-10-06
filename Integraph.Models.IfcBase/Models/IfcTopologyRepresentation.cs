using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctopologyrepresentation.htm" />
	/// </summary>
	public class IfcTopologyRepresentation : IfcShapeModel
    {
	    /// <summary>
	    ///     Construct a IfcTopologyRepresentation with all required attributes.
	    /// </summary>
	    public IfcTopologyRepresentation(IfcRepresentationContext contextOfItems, List<IfcRepresentationItem> items) :
            base(contextOfItems, items)
        {
        }

	    /// <summary>
	    ///     Construct a IfcTopologyRepresentation with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTopologyRepresentation(IfcRepresentationContext contextOfItems, IfcLabel representationIdentifier,
            IfcLabel representationType, List<IfcRepresentationItem> items) : base(contextOfItems,
            representationIdentifier, representationType, items)
        {
        }

        public new static IfcTopologyRepresentation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTopologyRepresentation>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            ContextOfItems != null ? ContextOfItems.ToStepValue() : "$",
	            RepresentationIdentifier != null ? RepresentationIdentifier.ToStepValue() : "$",
	            RepresentationType != null ? RepresentationType.ToStepValue() : "$",
	            Items != null ? Items.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}