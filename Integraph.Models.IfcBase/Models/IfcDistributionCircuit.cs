using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdistributioncircuit.htm" />
	/// </summary>
	public class IfcDistributionCircuit : IfcDistributionSystem
    {
	    /// <summary>
	    ///     Construct a IfcDistributionCircuit with all required attributes.
	    /// </summary>
	    public IfcDistributionCircuit(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcDistributionCircuit with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDistributionCircuit(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcLabel longName, IfcDistributionSystemEnum predefinedType) :
            base(globalId, ownerHistory, name, description, objectType, longName, predefinedType)
        {
        }

        public new static IfcDistributionCircuit FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDistributionCircuit>(json);
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