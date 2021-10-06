using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertysettemplate.htm" />
	/// </summary>
	public class IfcPropertySetTemplate : IfcPropertyTemplateDefinition
    {
	    /// <summary>
	    ///     Construct a IfcPropertySetTemplate with all required attributes.
	    /// </summary>
	    public IfcPropertySetTemplate(IfcGloballyUniqueId globalId, List<IfcPropertyTemplate> hasPropertyTemplates) :
            base(globalId)
        {
            Defines = new List<IfcRelDefinesByTemplate>();

            HasPropertyTemplates = hasPropertyTemplates;
        }

	    /// <summary>
	    ///     Construct a IfcPropertySetTemplate with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertySetTemplate(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcPropertySetTemplateTypeEnum templateType, IfcIdentifier applicableEntity,
            List<IfcPropertyTemplate> hasPropertyTemplates) : base(globalId, ownerHistory, name, description)
        {
            Defines = new List<IfcRelDefinesByTemplate>();

            TemplateType = templateType;
            ApplicableEntity = applicableEntity;
            HasPropertyTemplates = hasPropertyTemplates;
        }

        public IfcPropertySetTemplateTypeEnum? TemplateType { get; set; } // optional
        public IfcIdentifier ApplicableEntity { get; set; } // optional
        public List<IfcPropertyTemplate> HasPropertyTemplates { get; set; }
        public List<IfcRelDefinesByTemplate> Defines { get; set; } // inverse

        public new static IfcPropertySetTemplate FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertySetTemplate>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                TemplateType.ToStepValue(),
                ApplicableEntity != null ? ApplicableEntity.ToStepValue() : "$",
                HasPropertyTemplates != null ? HasPropertyTemplates.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}