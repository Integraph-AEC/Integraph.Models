using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcshaperepresentation.htm" />
	/// </summary>
	public class IfcShapeRepresentation : IfcShapeModel
    {
	    /// <summary>
	    ///     Construct a IfcShapeRepresentation with all required attributes.
	    /// </summary>
	    public IfcShapeRepresentation(IfcRepresentationContext contextOfItems, List<IfcRepresentationItem> items) :
            base(contextOfItems, items)
        {
        }

	    /// <summary>
	    ///     Construct a IfcShapeRepresentation with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcShapeRepresentation(IfcRepresentationContext contextOfItems, IfcLabel representationIdentifier,
            IfcLabel representationType, List<IfcRepresentationItem> items) : base(contextOfItems,
            representationIdentifier, representationType, items)
        {
        }

        public new static IfcShapeRepresentation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcShapeRepresentation>(json);
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