using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpredefinedpropertyset.htm" />
	/// </summary>
	public abstract class IfcPreDefinedPropertySet : IfcPropertySetDefinition
    {
	    /// <summary>
	    ///     Construct a IfcPreDefinedPropertySet with all required attributes.
	    /// </summary>
	    public IfcPreDefinedPropertySet(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcPreDefinedPropertySet with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPreDefinedPropertySet(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description) : base(globalId, ownerHistory, name, description)
        {
        }

        public new static IfcPreDefinedPropertySet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPreDefinedPropertySet>(json);
        }
    }
}