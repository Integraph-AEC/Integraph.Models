using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcproxy.htm" />
	/// </summary>
	public class IfcProxy : IfcProduct
    {
	    /// <summary>
	    ///     Construct a IfcProxy with all required attributes.
	    /// </summary>
	    public IfcProxy(IfcGloballyUniqueId globalId, IfcObjectTypeEnum proxyType) : base(globalId)
        {
            ProxyType = proxyType;
        }

	    /// <summary>
	    ///     Construct a IfcProxy with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcProxy(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcObjectPlacement objectPlacement, IfcProductRepresentation representation,
            IfcObjectTypeEnum proxyType, IfcLabel tag) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation)
        {
            ProxyType = proxyType;
            Tag = tag;
        }

        public IfcObjectTypeEnum? ProxyType { get; set; }
        public IfcLabel Tag { get; set; } // optional

        public new static IfcProxy FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcProxy>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ObjectType != null ? ObjectType.ToStepValue() : "$",
	            ObjectPlacement != null ? ObjectPlacement.ToStepValue() : "$",
	            Representation != null ? Representation.ToStepValue() : "$",
	            ProxyType.ToStepValue(),
	            Tag != null ? Tag.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}