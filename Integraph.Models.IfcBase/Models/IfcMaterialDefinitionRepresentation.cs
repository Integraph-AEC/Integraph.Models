using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialdefinitionrepresentation.htm" />
	/// </summary>
	public class IfcMaterialDefinitionRepresentation : IfcProductRepresentation
    {
	    /// <summary>
	    ///     Construct a IfcMaterialDefinitionRepresentation with all required attributes.
	    /// </summary>
	    public IfcMaterialDefinitionRepresentation(List<IfcRepresentation> representations,
            IfcMaterial representedMaterial) : base(representations)
        {
            RepresentedMaterial = representedMaterial;
        }

	    /// <summary>
	    ///     Construct a IfcMaterialDefinitionRepresentation with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialDefinitionRepresentation(IfcLabel name, IfcText description,
            List<IfcRepresentation> representations, IfcMaterial representedMaterial) : base(name, description,
            representations)
        {
            RepresentedMaterial = representedMaterial;
        }

        public IfcMaterial RepresentedMaterial { get; set; }

        public new static IfcMaterialDefinitionRepresentation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialDefinitionRepresentation>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                Representations != null ? Representations.ToStepValue() : "$",
                RepresentedMaterial != null ? RepresentedMaterial.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}