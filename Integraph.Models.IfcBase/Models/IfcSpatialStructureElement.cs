using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcspatialstructureelement.htm" />
	/// </summary>
	public abstract class IfcSpatialStructureElement : IfcSpatialElement
    {
	    /// <summary>
	    ///     Construct a IfcSpatialStructureElement with all required attributes.
	    /// </summary>
	    public IfcSpatialStructureElement(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcSpatialStructureElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSpatialStructureElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcLabel longName, IfcElementCompositionEnum compositionType) :
            base(globalId, ownerHistory, name, description, objectType, objectPlacement, representation, longName)
        {
            CompositionType = compositionType;
        }

        public IfcElementCompositionEnum? CompositionType { get; set; } // optional

        public new static IfcSpatialStructureElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSpatialStructureElement>(json);
        }
    }
}