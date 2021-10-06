using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifczone.htm" />
	/// </summary>
	public class IfcZone : IfcSystem
    {
	    /// <summary>
	    ///     Construct a IfcZone with all required attributes.
	    /// </summary>
	    public IfcZone(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcZone with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcZone(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcLabel longName) : base(globalId, ownerHistory, name, description, objectType)
        {
            LongName = longName;
        }

        public IfcLabel LongName { get; set; } // optional

        public new static IfcZone FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcZone>(json);
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
	            LongName != null ? LongName.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}