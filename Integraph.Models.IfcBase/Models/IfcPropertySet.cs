using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertyset.htm" />
	/// </summary>
	public class IfcPropertySet : IfcPropertySetDefinition
    {
	    /// <summary>
	    ///     Construct a IfcPropertySet with all required attributes.
	    /// </summary>
	    public IfcPropertySet(IfcGloballyUniqueId globalId, List<IfcProperty> hasProperties) : base(globalId)
        {
            HasProperties = hasProperties;
        }

	    /// <summary>
	    ///     Construct a IfcPropertySet with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertySet(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, List<IfcProperty> hasProperties) : base(globalId, ownerHistory, name, description)
        {
            HasProperties = hasProperties;
        }

        public List<IfcProperty> HasProperties { get; set; }

        public new static IfcPropertySet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertySet>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            HasProperties != null ? HasProperties.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}