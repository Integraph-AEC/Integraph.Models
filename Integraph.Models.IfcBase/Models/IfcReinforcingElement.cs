using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreinforcingelement.htm" />
	/// </summary>
	public abstract class IfcReinforcingElement : IfcElementComponent
    {
	    /// <summary>
	    ///     Construct a IfcReinforcingElement with all required attributes.
	    /// </summary>
	    public IfcReinforcingElement(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcReinforcingElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcReinforcingElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcLabel steelGrade) : base(globalId,
            ownerHistory, name, description, objectType, objectPlacement, representation, tag)
        {
            SteelGrade = steelGrade;
        }

        public IfcLabel SteelGrade { get; set; } // optional

        public new static IfcReinforcingElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcReinforcingElement>(json);
        }
    }
}