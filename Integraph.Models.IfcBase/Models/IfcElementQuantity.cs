using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcelementquantity.htm" />
	/// </summary>
	public class IfcElementQuantity : IfcQuantitySet
    {
	    /// <summary>
	    ///     Construct a IfcElementQuantity with all required attributes.
	    /// </summary>
	    public IfcElementQuantity(IfcGloballyUniqueId globalId, List<IfcPhysicalQuantity> quantities) : base(globalId)
        {
            Quantities = quantities;
        }

	    /// <summary>
	    ///     Construct a IfcElementQuantity with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcElementQuantity(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel methodOfMeasurement, List<IfcPhysicalQuantity> quantities) : base(globalId,
            ownerHistory, name, description)
        {
            MethodOfMeasurement = methodOfMeasurement;
            Quantities = quantities;
        }

        public IfcLabel MethodOfMeasurement { get; set; } // optional
        public List<IfcPhysicalQuantity> Quantities { get; set; }

        public new static IfcElementQuantity FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcElementQuantity>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            MethodOfMeasurement != null ? MethodOfMeasurement.ToStepValue() : "$",
	            Quantities != null ? Quantities.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}