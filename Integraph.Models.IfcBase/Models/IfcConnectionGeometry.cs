using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconnectiongeometry.htm" />
	/// </summary>
	public abstract class IfcConnectionGeometry : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcConnectionGeometry with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConnectionGeometry()
        {
        }

        public static IfcConnectionGeometry FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConnectionGeometry>(json);
        }
    }
}