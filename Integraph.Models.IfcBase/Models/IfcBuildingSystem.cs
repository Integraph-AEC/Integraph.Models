using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbuildingsystem.htm" />
	/// </summary>
	public class IfcBuildingSystem : IfcSystem
    {
	    /// <summary>
	    ///     Construct a IfcBuildingSystem with all required attributes.
	    /// </summary>
	    public IfcBuildingSystem(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcBuildingSystem with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBuildingSystem(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcBuildingSystemTypeEnum predefinedType, IfcLabel longName) :
            base(globalId, ownerHistory, name, description, objectType)
        {
            PredefinedType = predefinedType;
            LongName = longName;
        }

        public IfcBuildingSystemTypeEnum? PredefinedType { get; set; } // optional
        public IfcLabel LongName { get; set; } // optional

        public new static IfcBuildingSystem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBuildingSystem>(json);
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
	            PredefinedType.ToStepValue(),
	            LongName != null ? LongName.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}