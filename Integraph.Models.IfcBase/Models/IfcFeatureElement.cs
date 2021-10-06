using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfeatureelement.htm" />
	/// </summary>
	public abstract class IfcFeatureElement : IfcElement
    {
	    /// <summary>
	    ///     Construct a IfcFeatureElement with all required attributes.
	    /// </summary>
	    public IfcFeatureElement(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcFeatureElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFeatureElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag) : base(globalId, ownerHistory, name,
            description, objectType, objectPlacement, representation, tag)
        {
        }

        public new static IfcFeatureElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFeatureElement>(json);
        }
    }
}