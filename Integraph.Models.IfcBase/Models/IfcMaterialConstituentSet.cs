using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialconstituentset.htm" />
	/// </summary>
	public class IfcMaterialConstituentSet : IfcMaterialDefinition
    {
	    /// <summary>
	    ///     Construct a IfcMaterialConstituentSet with all required attributes.
	    /// </summary>
	    public IfcMaterialConstituentSet()
        {
            MaterialConstituents = new List<IfcMaterialConstituent>();
        }

	    /// <summary>
	    ///     Construct a IfcMaterialConstituentSet with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialConstituentSet(IfcLabel name, IfcText description,
            List<IfcMaterialConstituent> materialConstituents)
        {
            Name = name;
            Description = description;
            MaterialConstituents = materialConstituents;
        }

        public IfcLabel Name { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public List<IfcMaterialConstituent> MaterialConstituents { get; set; } // optional

        public new static IfcMaterialConstituentSet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialConstituentSet>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            MaterialConstituents != null ? MaterialConstituents.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}