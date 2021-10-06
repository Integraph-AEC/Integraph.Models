using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelationship.htm" />
	/// </summary>
	public abstract class IfcRelationship : IfcRoot
    {
	    /// <summary>
	    ///     Construct a IfcRelationship with all required attributes.
	    /// </summary>
	    public IfcRelationship(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcRelationship with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelationship(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description) : base(globalId, ownerHistory, name, description)
        {
        }

        public new static IfcRelationship FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelationship>(json);
        }
    }
}