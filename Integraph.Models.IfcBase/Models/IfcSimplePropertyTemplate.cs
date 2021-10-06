using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsimplepropertytemplate.htm" />
	/// </summary>
	public class IfcSimplePropertyTemplate : IfcPropertyTemplate
    {
	    /// <summary>
	    ///     Construct a IfcSimplePropertyTemplate with all required attributes.
	    /// </summary>
	    public IfcSimplePropertyTemplate(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcSimplePropertyTemplate with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSimplePropertyTemplate(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcSimplePropertyTemplateTypeEnum templateType, IfcLabel primaryMeasureType,
            IfcLabel secondaryMeasureType, IfcPropertyEnumeration enumerators, IfcUnit primaryUnit,
            IfcUnit secondaryUnit, IfcLabel expression, IfcStateEnum accessState) : base(globalId, ownerHistory, name,
            description)
        {
            TemplateType = templateType;
            PrimaryMeasureType = primaryMeasureType;
            SecondaryMeasureType = secondaryMeasureType;
            Enumerators = enumerators;
            PrimaryUnit = primaryUnit;
            SecondaryUnit = secondaryUnit;
            Expression = expression;
            AccessState = accessState;
        }

        public IfcSimplePropertyTemplateTypeEnum? TemplateType { get; set; } // optional
        public IfcLabel PrimaryMeasureType { get; set; } // optional
        public IfcLabel SecondaryMeasureType { get; set; } // optional
        public IfcPropertyEnumeration Enumerators { get; set; } // optional
        public IfcUnit PrimaryUnit { get; set; } // optional
        public IfcUnit SecondaryUnit { get; set; } // optional
        public IfcLabel Expression { get; set; } // optional
        public IfcStateEnum? AccessState { get; set; } // optional

        public new static IfcSimplePropertyTemplate FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSimplePropertyTemplate>(json);
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
	            PrimaryMeasureType != null ? PrimaryMeasureType.ToStepValue() : "$",
	            SecondaryMeasureType != null ? SecondaryMeasureType.ToStepValue() : "$",
	            Enumerators != null ? Enumerators.ToStepValue() : "$",
	            PrimaryUnit != null ? PrimaryUnit.ToStepValue() : "$",
	            SecondaryUnit != null ? SecondaryUnit.ToStepValue() : "$",
	            Expression != null ? Expression.ToStepValue() : "$",
	            AccessState.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}