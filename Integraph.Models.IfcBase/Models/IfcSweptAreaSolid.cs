using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsweptareasolid.htm" />
	/// </summary>
	public abstract class IfcSweptAreaSolid : IfcSolidModel
    {
	    /// <summary>
	    ///     Construct a IfcSweptAreaSolid with all required attributes.
	    /// </summary>
	    public IfcSweptAreaSolid(IfcProfileDef sweptArea)
        {
            SweptArea = sweptArea;
        }

	    /// <summary>
	    ///     Construct a IfcSweptAreaSolid with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSweptAreaSolid(IfcProfileDef sweptArea, IfcAxis2Placement3D position)
        {
            SweptArea = sweptArea;
            Position = position;
        }

        public IfcProfileDef SweptArea { get; set; }
        public IfcAxis2Placement3D Position { get; set; } // optional

        public new static IfcSweptAreaSolid FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSweptAreaSolid>(json);
        }
    }
}