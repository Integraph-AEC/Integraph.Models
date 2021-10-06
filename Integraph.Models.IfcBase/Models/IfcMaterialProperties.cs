using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialproperties.htm" />
	/// </summary>
	public class IfcMaterialProperties : IfcExtendedProperties
    {
	    /// <summary>
	    ///     Construct a IfcMaterialProperties with all required attributes.
	    /// </summary>
	    public IfcMaterialProperties(List<IfcProperty> properties, IfcMaterialDefinition material) : base(properties)
        {
            Material = material;
        }

	    /// <summary>
	    ///     Construct a IfcMaterialProperties with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialProperties(IfcIdentifier name, IfcText description, List<IfcProperty> properties,
            IfcMaterialDefinition material) : base(name, description, properties)
        {
            Material = material;
        }

        public IfcMaterialDefinition Material { get; set; }

        public new static IfcMaterialProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialProperties>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Properties != null ? Properties.ToStepValue() : "$",
	            Material != null ? Material.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}