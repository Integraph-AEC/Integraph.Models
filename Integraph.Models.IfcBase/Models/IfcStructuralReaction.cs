using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralreaction.htm" />
	/// </summary>
	public abstract class IfcStructuralReaction : IfcStructuralActivity
    {
	    /// <summary>
	    ///     Construct a IfcStructuralReaction with all required attributes.
	    /// </summary>
	    public IfcStructuralReaction(IfcGloballyUniqueId globalId, IfcStructuralLoad appliedLoad,
            IfcGlobalOrLocalEnum globalOrLocal) : base(globalId, appliedLoad, globalOrLocal)
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralReaction with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralReaction(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal)
            : base(globalId, ownerHistory, name, description, objectType, objectPlacement, representation, appliedLoad,
                globalOrLocal)
        {
        }

        public new static IfcStructuralReaction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralReaction>(json);
        }
    }
}