using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcelementassembly.htm" />
	/// </summary>
	public class IfcElementAssembly : IfcElement
    {
	    /// <summary>
	    ///     Construct a IfcElementAssembly with all required attributes.
	    /// </summary>
	    public IfcElementAssembly(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcElementAssembly with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcElementAssembly(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcAssemblyPlaceEnum assemblyPlace,
            IfcElementAssemblyTypeEnum predefinedType) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation, tag)
        {
            AssemblyPlace = assemblyPlace;
            PredefinedType = predefinedType;
        }

        public IfcAssemblyPlaceEnum? AssemblyPlace { get; set; } // optional
        public IfcElementAssemblyTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcElementAssembly FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcElementAssembly>(json);
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
	            AssemblyPlace.ToStepValue(),
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}