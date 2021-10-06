using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrepresentationitem.htm" />
	/// </summary>
	public abstract class IfcRepresentationItem : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcRepresentationItem with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRepresentationItem()
        {
            LayerAssignment = new List<IfcPresentationLayerAssignment>();
            StyledByItem = new List<IfcStyledItem>();
        }

        public List<IfcPresentationLayerAssignment> LayerAssignment { get; set; } // inverse
        public List<IfcStyledItem> StyledByItem { get; set; } // inverse

        public static IfcRepresentationItem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRepresentationItem>(json);
        }
    }
}