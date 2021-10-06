using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcobjectplacement.htm" />
	/// </summary>
	public abstract class IfcObjectPlacement : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcObjectPlacement with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcObjectPlacement()
        {
            PlacesObject = new List<IfcProduct>();
            ReferencedByPlacements = new List<IfcLocalPlacement>();
        }

        public List<IfcProduct> PlacesObject { get; set; } // inverse
        public List<IfcLocalPlacement> ReferencedByPlacements { get; set; } // inverse

        public static IfcObjectPlacement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcObjectPlacement>(json);
        }
    }
}