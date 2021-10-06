using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboundedcurve.htm" />
	/// </summary>
	public abstract class IfcBoundedCurve : IfcCurve
    {
	    /// <summary>
	    ///     Construct a IfcBoundedCurve with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBoundedCurve()
        {
        }

        public new static IfcBoundedCurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBoundedCurve>(json);
        }
    }
}