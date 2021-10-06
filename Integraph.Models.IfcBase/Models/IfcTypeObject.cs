using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctypeobject.htm" />
	/// </summary>
	public class IfcTypeObject : IfcObjectDefinition
    {
	    /// <summary>
	    ///     Construct a IfcTypeObject with all required attributes.
	    /// </summary>
	    public IfcTypeObject(IfcGloballyUniqueId globalId) : base(globalId)
        {
            HasPropertySets = new List<IfcPropertySetDefinition>();
            Types = new List<IfcRelDefinesByType>();
        }

	    /// <summary>
	    ///     Construct a IfcTypeObject with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTypeObject(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets) :
            base(globalId, ownerHistory, name, description)
        {
            Types = new List<IfcRelDefinesByType>();

            ApplicableOccurrence = applicableOccurrence;
            HasPropertySets = hasPropertySets;
        }

        public IfcIdentifier ApplicableOccurrence { get; set; } // optional
        public List<IfcPropertySetDefinition> HasPropertySets { get; set; } // optional
        public List<IfcRelDefinesByType> Types { get; set; } // inverse

        public new static IfcTypeObject FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTypeObject>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ApplicableOccurrence != null ? ApplicableOccurrence.ToStepValue() : "$",
	            HasPropertySets != null ? HasPropertySets.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}