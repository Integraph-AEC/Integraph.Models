using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpresentationlayerassignment.htm" />
	/// </summary>
	public class IfcPresentationLayerAssignment : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcPresentationLayerAssignment with all required attributes.
	    /// </summary>
	    public IfcPresentationLayerAssignment(IfcLabel name, List<IfcLayeredItem> assignedItems)
        {
            Name = name;
            AssignedItems = assignedItems;
        }

	    /// <summary>
	    ///     Construct a IfcPresentationLayerAssignment with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPresentationLayerAssignment(IfcLabel name, IfcText description, List<IfcLayeredItem> assignedItems,
            IfcIdentifier identifier)
        {
            Name = name;
            Description = description;
            AssignedItems = assignedItems;
            Identifier = identifier;
        }

        public IfcLabel Name { get; set; }
        public IfcText Description { get; set; } // optional
        public List<IfcLayeredItem> AssignedItems { get; set; }
        public IfcIdentifier Identifier { get; set; } // optional

        public static IfcPresentationLayerAssignment FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPresentationLayerAssignment>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            AssignedItems != null ? AssignedItems.ToStepValue() : "$",
	            Identifier != null ? Identifier.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}