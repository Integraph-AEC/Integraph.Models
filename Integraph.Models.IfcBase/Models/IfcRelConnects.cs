using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelconnects.htm" />
	/// </summary>
	public abstract class IfcRelConnects : IfcRelationship
    {
	    /// <summary>
	    ///     Construct a IfcRelConnects with all required attributes.
	    /// </summary>
	    public IfcRelConnects(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcRelConnects with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelConnects(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description) : base(globalId, ownerHistory, name, description)
        {
        }

        public new static IfcRelConnects FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelConnects>(json);
        }
    }
}