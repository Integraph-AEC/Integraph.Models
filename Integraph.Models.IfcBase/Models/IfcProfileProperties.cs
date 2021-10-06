using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcprofileproperties.htm" />
	/// </summary>
	public class IfcProfileProperties : IfcExtendedProperties
    {
	    /// <summary>
	    ///     Construct a IfcProfileProperties with all required attributes.
	    /// </summary>
	    public IfcProfileProperties(List<IfcProperty> properties, IfcProfileDef profileDefinition) : base(properties)
        {
            ProfileDefinition = profileDefinition;
        }

	    /// <summary>
	    ///     Construct a IfcProfileProperties with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcProfileProperties(IfcIdentifier name, IfcText description, List<IfcProperty> properties,
            IfcProfileDef profileDefinition) : base(name, description, properties)
        {
            ProfileDefinition = profileDefinition;
        }

        public IfcProfileDef ProfileDefinition { get; set; }

        public new static IfcProfileProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcProfileProperties>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Properties != null ? Properties.ToStepValue() : "$",
	            ProfileDefinition != null ? ProfileDefinition.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}