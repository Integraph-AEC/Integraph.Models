using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcphysicalcomplexquantity.htm" />
	/// </summary>
	public class IfcPhysicalComplexQuantity : IfcPhysicalQuantity
    {
	    /// <summary>
	    ///     Construct a IfcPhysicalComplexQuantity with all required attributes.
	    /// </summary>
	    public IfcPhysicalComplexQuantity(IfcLabel name, List<IfcPhysicalQuantity> hasQuantities,
            IfcLabel discrimination) : base(name)
        {
            HasQuantities = hasQuantities;
            Discrimination = discrimination;
        }

	    /// <summary>
	    ///     Construct a IfcPhysicalComplexQuantity with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPhysicalComplexQuantity(IfcLabel name, IfcText description, List<IfcPhysicalQuantity> hasQuantities,
            IfcLabel discrimination, IfcLabel quality, IfcLabel usage) : base(name, description)
        {
            HasQuantities = hasQuantities;
            Discrimination = discrimination;
            Quality = quality;
            Usage = usage;
        }

        public List<IfcPhysicalQuantity> HasQuantities { get; set; }
        public IfcLabel Discrimination { get; set; }
        public IfcLabel Quality { get; set; } // optional
        public IfcLabel Usage { get; set; } // optional

        public new static IfcPhysicalComplexQuantity FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPhysicalComplexQuantity>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                HasQuantities != null ? HasQuantities.ToStepValue() : "$",
                Discrimination != null ? Discrimination.ToStepValue() : "$",
                Quality != null ? Quality.ToStepValue() : "$",
                Usage != null ? Usage.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}