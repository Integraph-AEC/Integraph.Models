using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdistributionsystem.htm" />
	/// </summary>
	public class IfcDistributionSystem : IfcSystem
    {
	    /// <summary>
	    ///     Construct a IfcDistributionSystem with all required attributes.
	    /// </summary>
	    public IfcDistributionSystem(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcDistributionSystem with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDistributionSystem(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcLabel longName, IfcDistributionSystemEnum predefinedType) :
            base(globalId, ownerHistory, name, description, objectType)
        {
            LongName = longName;
            PredefinedType = predefinedType;
        }

        public IfcLabel LongName { get; set; } // optional
        public IfcDistributionSystemEnum? PredefinedType { get; set; } // optional

        public new static IfcDistributionSystem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDistributionSystem>(json);
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
	            LongName != null ? LongName.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}