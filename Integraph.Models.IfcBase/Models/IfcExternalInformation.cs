using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcexternalinformation.htm" />
	/// </summary>
	public abstract class IfcExternalInformation : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcExternalInformation with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcExternalInformation()
        {
        }

        public static IfcExternalInformation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcExternalInformation>(json);
        }
    }
}