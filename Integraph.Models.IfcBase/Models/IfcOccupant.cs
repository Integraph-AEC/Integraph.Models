using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcoccupant.htm" />
	/// </summary>
	public class IfcOccupant : IfcActor
    {
	    /// <summary>
	    ///     Construct a IfcOccupant with all required attributes.
	    /// </summary>
	    public IfcOccupant(IfcGloballyUniqueId globalId, IfcActorSelect theActor) : base(globalId, theActor)
        {
        }

	    /// <summary>
	    ///     Construct a IfcOccupant with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcOccupant(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcActorSelect theActor, IfcOccupantTypeEnum predefinedType) :
            base(globalId, ownerHistory, name, description, objectType, theActor)
        {
            PredefinedType = predefinedType;
        }

        public IfcOccupantTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcOccupant FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcOccupant>(json);
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
	            TheActor != null ? TheActor.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}