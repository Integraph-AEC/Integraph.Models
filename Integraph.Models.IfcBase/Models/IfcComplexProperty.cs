using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccomplexproperty.htm" />
	/// </summary>
	public class IfcComplexProperty : IfcProperty
    {
	    /// <summary>
	    ///     Construct a IfcComplexProperty with all required attributes.
	    /// </summary>
	    public IfcComplexProperty(IfcIdentifier name, IfcIdentifier usageName, List<IfcProperty> hasProperties) :
            base(name)
        {
            UsageName = usageName;
            HasProperties = hasProperties;
        }

	    /// <summary>
	    ///     Construct a IfcComplexProperty with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcComplexProperty(IfcIdentifier name, IfcText description, IfcIdentifier usageName,
            List<IfcProperty> hasProperties) : base(name, description)
        {
            UsageName = usageName;
            HasProperties = hasProperties;
        }

        public IfcIdentifier UsageName { get; set; }
        public List<IfcProperty> HasProperties { get; set; }

        public new static IfcComplexProperty FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcComplexProperty>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                UsageName != null ? UsageName.ToStepValue() : "$",
                HasProperties != null ? HasProperties.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}