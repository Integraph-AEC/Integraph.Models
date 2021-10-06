using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcspatialzone.htm" />
	/// </summary>
	public class IfcSpatialZone : IfcSpatialElement
    {
	    /// <summary>
	    ///     Construct a IfcSpatialZone with all required attributes.
	    /// </summary>
	    public IfcSpatialZone(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcSpatialZone with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSpatialZone(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcLabel longName, IfcSpatialZoneTypeEnum predefinedType) : base(
            globalId, ownerHistory, name, description, objectType, objectPlacement, representation, longName)
        {
            PredefinedType = predefinedType;
        }

        public IfcSpatialZoneTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcSpatialZone FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSpatialZone>(json);
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