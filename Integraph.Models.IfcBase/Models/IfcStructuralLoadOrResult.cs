using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralloadorresult.htm" />
	/// </summary>
	public abstract class IfcStructuralLoadOrResult : IfcStructuralLoad
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLoadOrResult with all required attributes.
	    /// </summary>
	    public IfcStructuralLoadOrResult()
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLoadOrResult with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLoadOrResult(IfcLabel name) : base(name)
        {
        }

        public new static IfcStructuralLoadOrResult FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLoadOrResult>(json);
        }
    }
}