using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralload.htm" />
	/// </summary>
	public abstract class IfcStructuralLoad : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLoad with all required attributes.
	    /// </summary>
	    public IfcStructuralLoad()
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLoad with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLoad(IfcLabel name)
        {
            Name = name;
        }

        public IfcLabel Name { get; set; } // optional

        public static IfcStructuralLoad FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLoad>(json);
        }
    }
}