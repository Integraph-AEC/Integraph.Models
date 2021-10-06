using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreldecomposes.htm" />
	/// </summary>
	public abstract class IfcRelDecomposes : IfcRelationship
    {
	    /// <summary>
	    ///     Construct a IfcRelDecomposes with all required attributes.
	    /// </summary>
	    public IfcRelDecomposes(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcRelDecomposes with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelDecomposes(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description) : base(globalId, ownerHistory, name, description)
        {
        }

        public new static IfcRelDecomposes FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelDecomposes>(json);
        }
    }
}