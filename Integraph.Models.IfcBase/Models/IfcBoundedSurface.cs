using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboundedsurface.htm" />
	/// </summary>
	public abstract class IfcBoundedSurface : IfcSurface
    {
	    /// <summary>
	    ///     Construct a IfcBoundedSurface with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBoundedSurface()
        {
        }

        public new static IfcBoundedSurface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBoundedSurface>(json);
        }
    }
}