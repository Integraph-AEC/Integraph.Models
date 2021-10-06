using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertyreferencevalue.htm" />
	/// </summary>
	public class IfcPropertyReferenceValue : IfcSimpleProperty
    {
	    /// <summary>
	    ///     Construct a IfcPropertyReferenceValue with all required attributes.
	    /// </summary>
	    public IfcPropertyReferenceValue(IfcIdentifier name) : base(name)
        {
        }

	    /// <summary>
	    ///     Construct a IfcPropertyReferenceValue with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertyReferenceValue(IfcIdentifier name, IfcText description, IfcText usageName,
            IfcObjectReferenceSelect propertyReference) : base(name, description)
        {
            UsageName = usageName;
            PropertyReference = propertyReference;
        }

        public IfcText UsageName { get; set; } // optional
        public IfcObjectReferenceSelect PropertyReference { get; set; } // optional

        public new static IfcPropertyReferenceValue FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertyReferenceValue>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            UsageName != null ? UsageName.ToStepValue() : "$",
	            PropertyReference != null ? PropertyReference.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}