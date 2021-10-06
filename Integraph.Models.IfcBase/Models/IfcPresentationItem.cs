using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpresentationitem.htm" />
	/// </summary>
	public abstract class IfcPresentationItem : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcPresentationItem with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPresentationItem()
        {
        }

        public static IfcPresentationItem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPresentationItem>(json);
        }
    }
}