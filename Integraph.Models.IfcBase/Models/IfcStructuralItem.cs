using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralitem.htm" />
	/// </summary>
	public abstract class IfcStructuralItem : IfcProduct
    {
	    /// <summary>
	    ///     Construct a IfcStructuralItem with all required attributes.
	    /// </summary>
	    public IfcStructuralItem(IfcGloballyUniqueId globalId) : base(globalId)
        {
            AssignedStructuralActivity = new List<IfcRelConnectsStructuralActivity>();
        }

	    /// <summary>
	    ///     Construct a IfcStructuralItem with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralItem(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation)
        {
            AssignedStructuralActivity = new List<IfcRelConnectsStructuralActivity>();
        }

        public List<IfcRelConnectsStructuralActivity> AssignedStructuralActivity { get; set; } // inverse

        public new static IfcStructuralItem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralItem>(json);
        }
    }
}