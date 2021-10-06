using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcelementarysurface.htm" />
	/// </summary>
	public abstract class IfcElementarySurface : IfcSurface
    {
	    /// <summary>
	    ///     Construct a IfcElementarySurface with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcElementarySurface(IfcAxis2Placement3D position)
        {
            Position = position;
        }

        public IfcAxis2Placement3D Position { get; set; }

        public new static IfcElementarySurface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcElementarySurface>(json);
        }
    }
}