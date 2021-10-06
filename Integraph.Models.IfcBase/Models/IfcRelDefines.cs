using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreldefines.htm" />
	/// </summary>
	public abstract class IfcRelDefines : IfcRelationship
    {
	    /// <summary>
	    ///     Construct a IfcRelDefines with all required attributes.
	    /// </summary>
	    public IfcRelDefines(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcRelDefines with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelDefines(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description) : base(globalId, ownerHistory, name, description)
        {
        }

        public new static IfcRelDefines FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelDefines>(json);
        }
    }
}