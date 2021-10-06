using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccomplexpropertytemplate.htm" />
	/// </summary>
	public class IfcComplexPropertyTemplate : IfcPropertyTemplate
    {
	    /// <summary>
	    ///     Construct a IfcComplexPropertyTemplate with all required attributes.
	    /// </summary>
	    public IfcComplexPropertyTemplate(IfcGloballyUniqueId globalId) : base(globalId)
        {
            HasPropertyTemplates = new List<IfcPropertyTemplate>();
        }

	    /// <summary>
	    ///     Construct a IfcComplexPropertyTemplate with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcComplexPropertyTemplate(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel usageName, IfcComplexPropertyTemplateTypeEnum templateType,
            List<IfcPropertyTemplate> hasPropertyTemplates) : base(globalId, ownerHistory, name, description)
        {
            UsageName = usageName;
            TemplateType = templateType;
            HasPropertyTemplates = hasPropertyTemplates;
        }

        public IfcLabel UsageName { get; set; } // optional
        public IfcComplexPropertyTemplateTypeEnum? TemplateType { get; set; } // optional
        public List<IfcPropertyTemplate> HasPropertyTemplates { get; set; } // optional

        public new static IfcComplexPropertyTemplate FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcComplexPropertyTemplate>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            UsageName != null ? UsageName.ToStepValue() : "$",
	            TemplateType.ToStepValue(),
	            HasPropertyTemplates != null ? HasPropertyTemplates.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}