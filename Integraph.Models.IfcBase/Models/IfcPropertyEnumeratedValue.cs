using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertyenumeratedvalue.htm" />
	/// </summary>
	public class IfcPropertyEnumeratedValue : IfcSimpleProperty
    {
	    /// <summary>
	    ///     Construct a IfcPropertyEnumeratedValue with all required attributes.
	    /// </summary>
	    public IfcPropertyEnumeratedValue(IfcIdentifier name) : base(name)
        {
            EnumerationValues = new List<IfcValue>();
        }

	    /// <summary>
	    ///     Construct a IfcPropertyEnumeratedValue with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertyEnumeratedValue(IfcIdentifier name, IfcText description, List<IfcValue> enumerationValues,
            IfcPropertyEnumeration enumerationReference) : base(name, description)
        {
            EnumerationValues = enumerationValues;
            EnumerationReference = enumerationReference;
        }

        public List<IfcValue> EnumerationValues { get; set; } // optional
        public IfcPropertyEnumeration EnumerationReference { get; set; } // optional

        public new static IfcPropertyEnumeratedValue FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertyEnumeratedValue>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            EnumerationValues != null ? EnumerationValues.ToStepValue() : "$",
	            EnumerationReference != null ? EnumerationReference.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}