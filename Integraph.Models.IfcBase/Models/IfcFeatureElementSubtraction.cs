using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfeatureelementsubtraction.htm" />
	/// </summary>
	public abstract class IfcFeatureElementSubtraction : IfcFeatureElement
    {
	    /// <summary>
	    ///     Construct a IfcFeatureElementSubtraction with all required attributes.
	    /// </summary>
	    public IfcFeatureElementSubtraction(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcFeatureElementSubtraction with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFeatureElementSubtraction(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag) : base(globalId, ownerHistory, name,
            description, objectType, objectPlacement, representation, tag)
        {
        }

        public IfcRelVoidsElement VoidsElements { get; set; } // inverse

        public new static IfcFeatureElementSubtraction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFeatureElementSubtraction>(json);
        }
    }
}