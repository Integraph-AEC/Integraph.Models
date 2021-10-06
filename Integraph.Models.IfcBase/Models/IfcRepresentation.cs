using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrepresentation.htm" />
	/// </summary>
	public abstract class IfcRepresentation : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcRepresentation with all required attributes.
	    /// </summary>
	    public IfcRepresentation(IfcRepresentationContext contextOfItems, List<IfcRepresentationItem> items)
        {
            RepresentationMap = new List<IfcRepresentationMap>();
            LayerAssignments = new List<IfcPresentationLayerAssignment>();
            OfProductRepresentation = new List<IfcProductRepresentation>();

            ContextOfItems = contextOfItems;
            Items = items;
        }

	    /// <summary>
	    ///     Construct a IfcRepresentation with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRepresentation(IfcRepresentationContext contextOfItems, IfcLabel representationIdentifier,
            IfcLabel representationType, List<IfcRepresentationItem> items)
        {
            RepresentationMap = new List<IfcRepresentationMap>();
            LayerAssignments = new List<IfcPresentationLayerAssignment>();
            OfProductRepresentation = new List<IfcProductRepresentation>();

            ContextOfItems = contextOfItems;
            RepresentationIdentifier = representationIdentifier;
            RepresentationType = representationType;
            Items = items;
        }

        public IfcRepresentationContext ContextOfItems { get; set; }
        public IfcLabel RepresentationIdentifier { get; set; } // optional
        public IfcLabel RepresentationType { get; set; } // optional
        public List<IfcRepresentationItem> Items { get; set; }
        public List<IfcRepresentationMap> RepresentationMap { get; set; } // inverse
        public List<IfcPresentationLayerAssignment> LayerAssignments { get; set; } // inverse
        public List<IfcProductRepresentation> OfProductRepresentation { get; set; } // inverse

        public static IfcRepresentation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRepresentation>(json);
        }
    }
}