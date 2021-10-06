using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcactor.htm" />
	/// </summary>
	public class IfcActor : IfcObject
    {
	    /// <summary>
	    ///     Construct a IfcActor with all required attributes.
	    /// </summary>
	    public IfcActor(IfcGloballyUniqueId globalId, IfcActorSelect theActor) : base(globalId)
        {
            IsActingUpon = new List<IfcRelAssignsToActor>();

            TheActor = theActor;
        }

	    /// <summary>
	    ///     Construct a IfcActor with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcActor(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcActorSelect theActor) : base(globalId, ownerHistory, name, description, objectType)
        {
            IsActingUpon = new List<IfcRelAssignsToActor>();

            TheActor = theActor;
        }

        public IfcActorSelect TheActor { get; set; }
        public List<IfcRelAssignsToActor> IsActingUpon { get; set; } // inverse

        public new static IfcActor FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcActor>(json);
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
	            TheActor != null ? TheActor.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}