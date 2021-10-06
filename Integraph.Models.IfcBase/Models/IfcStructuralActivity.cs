using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralactivity.htm" />
	/// </summary>
	public abstract class IfcStructuralActivity : IfcProduct
    {
	    /// <summary>
	    ///     Construct a IfcStructuralActivity with all required attributes.
	    /// </summary>
	    public IfcStructuralActivity(IfcGloballyUniqueId globalId, IfcStructuralLoad appliedLoad,
            IfcGlobalOrLocalEnum globalOrLocal) : base(globalId)
        {
            AssignedToStructuralItem = new List<IfcRelConnectsStructuralActivity>();

            AppliedLoad = appliedLoad;
            GlobalOrLocal = globalOrLocal;
        }

	    /// <summary>
	    ///     Construct a IfcStructuralActivity with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralActivity(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal)
            : base(globalId, ownerHistory, name, description, objectType, objectPlacement, representation)
        {
            AssignedToStructuralItem = new List<IfcRelConnectsStructuralActivity>();

            AppliedLoad = appliedLoad;
            GlobalOrLocal = globalOrLocal;
        }

        public IfcStructuralLoad AppliedLoad { get; set; }
        public IfcGlobalOrLocalEnum? GlobalOrLocal { get; set; }
        public List<IfcRelConnectsStructuralActivity> AssignedToStructuralItem { get; set; } // inverse

        public new static IfcStructuralActivity FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralActivity>(json);
        }
    }
}