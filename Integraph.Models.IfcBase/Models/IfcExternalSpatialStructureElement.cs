using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcexternalspatialstructureelement.htm" />
	/// </summary>
	public abstract class IfcExternalSpatialStructureElement : IfcSpatialElement
    {
	    /// <summary>
	    ///     Construct a IfcExternalSpatialStructureElement with all required attributes.
	    /// </summary>
	    public IfcExternalSpatialStructureElement(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcExternalSpatialStructureElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcExternalSpatialStructureElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory,
            IfcLabel name, IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcLabel longName) : base(globalId, ownerHistory, name,
            description, objectType, objectPlacement, representation, longName)
        {
        }

        public new static IfcExternalSpatialStructureElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcExternalSpatialStructureElement>(json);
        }
    }
}