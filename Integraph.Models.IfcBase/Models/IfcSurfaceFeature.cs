using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfacefeature.htm" />
	/// </summary>
	public class IfcSurfaceFeature : IfcFeatureElement
    {
	    /// <summary>
	    ///     Construct a IfcSurfaceFeature with all required attributes.
	    /// </summary>
	    public IfcSurfaceFeature(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcSurfaceFeature with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSurfaceFeature(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcSurfaceFeatureTypeEnum predefinedType) :
            base(globalId, ownerHistory, name, description, objectType, objectPlacement, representation, tag)
        {
            PredefinedType = predefinedType;
        }

        public IfcSurfaceFeatureTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcSurfaceFeature FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSurfaceFeature>(json);
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