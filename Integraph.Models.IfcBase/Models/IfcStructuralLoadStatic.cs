using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralloadstatic.htm" />
	/// </summary>
	public abstract class IfcStructuralLoadStatic : IfcStructuralLoadOrResult
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLoadStatic with all required attributes.
	    /// </summary>
	    public IfcStructuralLoadStatic()
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLoadStatic with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLoadStatic(IfcLabel name) : base(name)
        {
        }

        public new static IfcStructuralLoadStatic FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLoadStatic>(json);
        }
    }
}