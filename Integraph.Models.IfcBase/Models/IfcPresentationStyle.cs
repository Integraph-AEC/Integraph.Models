using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpresentationstyle.htm" />
	/// </summary>
	public abstract class IfcPresentationStyle : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcPresentationStyle with all required attributes.
	    /// </summary>
	    public IfcPresentationStyle()
        {
        }

	    /// <summary>
	    ///     Construct a IfcPresentationStyle with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPresentationStyle(IfcLabel name)
        {
            Name = name;
        }

        public IfcLabel Name { get; set; } // optional

        public static IfcPresentationStyle FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPresentationStyle>(json);
        }
    }
}