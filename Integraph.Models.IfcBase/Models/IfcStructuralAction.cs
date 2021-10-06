using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralaction.htm" />
	/// </summary>
	public abstract class IfcStructuralAction : IfcStructuralActivity
    {
	    /// <summary>
	    ///     Construct a IfcStructuralAction with all required attributes.
	    /// </summary>
	    public IfcStructuralAction(IfcGloballyUniqueId globalId, IfcStructuralLoad appliedLoad,
            IfcGlobalOrLocalEnum globalOrLocal) : base(globalId, appliedLoad, globalOrLocal)
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralAction with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralAction(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcStructuralLoad appliedLoad, IfcGlobalOrLocalEnum globalOrLocal,
            IfcBoolean destabilizingLoad) : base(globalId, ownerHistory, name, description, objectType, objectPlacement,
            representation, appliedLoad, globalOrLocal)
        {
            DestabilizingLoad = destabilizingLoad;
        }

        public IfcBoolean DestabilizingLoad { get; set; } // optional

        public new static IfcStructuralAction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralAction>(json);
        }
    }
}