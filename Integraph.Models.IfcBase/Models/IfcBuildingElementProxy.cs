using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbuildingelementproxy.htm" />
	/// </summary>
	public class IfcBuildingElementProxy : IfcBuildingElement
    {
	    /// <summary>
	    ///     Construct a IfcBuildingElementProxy with all required attributes.
	    /// </summary>
	    public IfcBuildingElementProxy(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcBuildingElementProxy with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBuildingElementProxy(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcBuildingElementProxyTypeEnum predefinedType)
            : base(globalId, ownerHistory, name, description, objectType, objectPlacement, representation, tag)
        {
            PredefinedType = predefinedType;
        }

        public IfcBuildingElementProxyTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcBuildingElementProxy FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBuildingElementProxy>(json);
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
	            Tag != null ? Tag.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}