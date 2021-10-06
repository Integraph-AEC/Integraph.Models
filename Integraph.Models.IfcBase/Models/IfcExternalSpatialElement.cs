using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcexternalspatialelement.htm" />
	/// </summary>
	public class IfcExternalSpatialElement : IfcExternalSpatialStructureElement
    {
	    /// <summary>
	    ///     Construct a IfcExternalSpatialElement with all required attributes.
	    /// </summary>
	    public IfcExternalSpatialElement(IfcGloballyUniqueId globalId) : base(globalId)
        {
            BoundedBy = new List<IfcRelSpaceBoundary>();
        }

	    /// <summary>
	    ///     Construct a IfcExternalSpatialElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcExternalSpatialElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcLabel longName,
            IfcExternalSpatialElementTypeEnum predefinedType) : base(globalId, ownerHistory, name, description,
            objectType, objectPlacement, representation, longName)
        {
            BoundedBy = new List<IfcRelSpaceBoundary>();

            PredefinedType = predefinedType;
        }

        public IfcExternalSpatialElementTypeEnum? PredefinedType { get; set; } // optional
        public List<IfcRelSpaceBoundary> BoundedBy { get; set; } // inverse

        public new static IfcExternalSpatialElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcExternalSpatialElement>(json);
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
	            LongName != null ? LongName.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}