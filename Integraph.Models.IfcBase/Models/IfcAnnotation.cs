using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcannotation.htm" />
	/// </summary>
	public class IfcAnnotation : IfcProduct
    {
	    /// <summary>
	    ///     Construct a IfcAnnotation with all required attributes.
	    /// </summary>
	    public IfcAnnotation(IfcGloballyUniqueId globalId) : base(globalId)
        {
            ContainedInStructure = new List<IfcRelContainedInSpatialStructure>();
        }

	    /// <summary>
	    ///     Construct a IfcAnnotation with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcAnnotation(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation)
        {
            ContainedInStructure = new List<IfcRelContainedInSpatialStructure>();
        }

        public List<IfcRelContainedInSpatialStructure> ContainedInStructure { get; set; } // inverse

        public new static IfcAnnotation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAnnotation>(json);
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
	            Representation != null ? Representation.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}